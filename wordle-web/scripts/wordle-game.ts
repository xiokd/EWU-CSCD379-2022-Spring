import { Word } from '@/scripts/word'

export enum GameState {
  Active = 0,
  Won = 1,
  Lost = 2,
}

export class WordleGame {
  constructor(word: string) {
    this.words.push(new Word())
    this.word = word
  }

  private word: string
  words: Word[] = []
  state: GameState = GameState.Active
  readonly maxGuess = 6

  get currentWord(): Word {
    return this.words[this.words.length - 1]
  }

  submitWord() {
    if (this.currentWord.evaluateWord(this.word)) {
      this.state = GameState.Won
    } else if (this.words.length === this.maxGuess) {
      this.state = GameState.Lost
    } else {
      this.words.push(new Word())
    }
  }
}
