import { Word } from '@/scripts/word'

describe('Game Test', () => {
  test('is an instance', () => {
    const word = new Word()
    expect(word).toBeTruthy()
    word.addLetter('A')
    expect(word.length).toEqual(1)
    word.removeLetter()
    expect(word.length).toEqual(0)
  })
})
