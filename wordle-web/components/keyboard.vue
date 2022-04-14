<template>
  <v-card class="my-5 pa-5">
    <v-row v-for="(keyRow, i) in keys" :key="i" no-gutters justify="center">
      <v-col v-for="key in keyRow" :key="key" cols="1">
        <v-container class="text-center">
          <v-btn :color="letterColor(key)" :disabled="wordleGame.gameOver" @click="setLetter(key)">
            {{ key }}
          </v-btn>
        </v-container>
      </v-col>
    </v-row>
    <v-btn
      :disabled="wordleGame.gameOver"
      class="float-left"
      @click="guessWord"
    >
      Guess
    </v-btn>
    <v-btn
      :disabled="wordleGame.gameOver"
      icon
      class="float-right"
      @click="removeLetter"
    >
      <v-icon>mdi-backspace</v-icon>
    </v-btn>
  </v-card>
</template>

<script lang="ts">
import { Component, Vue, Prop } from 'vue-property-decorator'
import { Letter, LetterStatus } from '~/scripts/letter';
import { WordleGame } from '~/scripts/wordleGame'

@Component
export default class KeyBoard extends Vue {
  @Prop({ required: true })
  wordleGame!: WordleGame

  keys = [
    ['q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p'],
    ['a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l'],
    ['z', 'x', 'c', 'v', 'b', 'n', 'm', '?'],
  ]

  setLetter(letter: string) {
      this.wordleGame.currentWord.addLetter(letter);
  }

  removeLetter() {
      this.wordleGame.currentWord.removeLetter();
  }

  guessWord() {
      if(this.wordleGame.currentWord.length === this.wordleGame.currentWord.maxLetters){
        this.wordleGame.submitWord();
      }
  }

  letterColor(char: string): string {
    if(this.wordleGame.correctChars.includes(char)){
        return Letter.getColorCode(LetterStatus.Correct)
    }
    if(this.wordleGame.wrongPlaceLetters.includes(char)){
        return Letter.getColorCode(LetterStatus.WrongPlace)
    }
    if(this.wordleGame.wrongLetters.includes(char)){
        return Letter.getColorCode(LetterStatus.Wrong)
    }

    return Letter.getColorCode(LetterStatus.Unknown)
  }
}
</script>
