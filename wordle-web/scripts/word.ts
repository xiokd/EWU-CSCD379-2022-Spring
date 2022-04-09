import { Letter } from '~/scripts/letter'

export class Word {
  private letters: Letter[] = []

  addLetter(char: string) {
    if (this.letters.length < 5) {
      this.letters.push(new Letter(char))
    }
  }

  removeLetter() {
    if (this.letters.length > 0) {
      this.letters.pop()
    }
  }

  evaluateWord(word: string) {
    if (word.length === this.letters.length) {
      // Determine which letters are in the right spots
    }
  }

  get length() {
    return this.letters.length
  }
}
