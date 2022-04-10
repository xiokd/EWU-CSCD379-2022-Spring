import { Letter, LetterStatus } from '~/scripts/letter'

export class Word {
  readonly letters: Letter[] = []

  get text() {
    return this.letters.map((f) => f.char).join('')
  }

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

  evaluateWord(word: string): boolean {
    let result = true
    if (word.length === this.letters.length) {
      const wordLettersLeft = word.split('')
      for (const [index, letter] of this.letters.entries()) {
        // Determine which letters are in the right spots
        if (word[index] === letter.char) {
          letter.status = LetterStatus.Correct
          // Remove the item
          wordLettersLeft.splice(wordLettersLeft.indexOf(letter.char), 1)
        } else if (wordLettersLeft.includes(letter.char)) {
          letter.status = LetterStatus.WrongPlace
          // Remove the item
          wordLettersLeft.splice(wordLettersLeft.indexOf(letter.char), 1)
          result = false
        } else {
          letter.status = LetterStatus.Wrong
          result = false
        }
      }
    }
    return result
  }

  get length() {
    return this.letters.length
  }
}
