<template>
  <v-card class="my-5 pa-5"
  style = "background: linear-gradient(180deg, rgba(10,10,100,1) 0%, rgba(5,50,90,1) 85%, rgba(5,50,85,.5) 100%)">
    <v-row v-for="(charRow, i) in chars" :key="i" no-gutters justify="center">
      <v-col v-for="char in charRow" :key="char" cols="1">
        <v-container class="text-center">
          <v-btn
            elevation = "7"
            :color="letterColor(char)"
            :disabled="wordleGame.gameOver"
            @click="setLetter(char)"
          >
            {{ char }}
          </v-btn>
        </v-container>
      </v-col>
    </v-row>
    <v-layout align-space-between justify-space-between> 
      <v-btn
        :disabled="wordleGame.gameOver"
        class="float-left"
        @click="guessWord"
      >
        Guess
      </v-btn>
      <!--make scroll-->
      <v-dialog
        v-model="dialog"
        scrollable
        max-width="300px"
      >
        <template v-slot:activator="{ on, attrs }">
          <v-btn
            color="primary"
            dark
            v-bind="attrs"
            v-on="on"
          >
          {{availableWords}} Available Words
          </v-btn>
        </template>
        <v-card>
          <v-card-title> Available Words </v-card-title>
          <divider></divider>
          <v-card-text style="height: 30px;"> </v-card-text>
        </v-card>
      </v-dialog>
      <v-btn
        :disabled="wordleGame.gameOver"
        icon
        class="float-right"
        @click="removeLetter"
      >
        <v-icon>mdi-backspace</v-icon>
      </v-btn>
    </v-layout>
  </v-card>
</template>

<script lang="ts">
import { Component, Vue, Prop } from 'vue-property-decorator'
import { Letter, LetterStatus } from '~/scripts/letter'
import { WordleGame } from '~/scripts/wordleGame'
import { WordsService } from '~/scripts/wordsService'

@Component
export default class KeyBoard extends Vue {
  @Prop({ required: true })
  wordleGame!: WordleGame

  chars = [
    ['q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p'],
    ['a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l'],
    ['z', 'x', 'c', 'v', 'b', 'n', 'm', '?'],
  ]

  setLetter(char: string) {
    this.wordleGame.currentWord.addLetter(char)
  }

  removeLetter() {
    this.wordleGame.currentWord.removeLetter()
  }

  guessWord() {
    if (
      this.wordleGame.currentWord.length ===
      this.wordleGame.currentWord.maxLetters
    ) {
      this.wordleGame.submitWord()
    }
  }

  letterColor(char: string): string {
    if (this.wordleGame.correctChars.includes(char)) {
      return Letter.getColorCode(LetterStatus.Correct)
    }
    if (this.wordleGame.wrongPlaceChars.includes(char)) {
      return Letter.getColorCode(LetterStatus.WrongPlace)
    }
    if (this.wordleGame.wrongChars.includes(char)) {
      return Letter.getColorCode(LetterStatus.Wrong)
    }

    return Letter.getColorCode(LetterStatus.Unknown)
  }
}
</script>
