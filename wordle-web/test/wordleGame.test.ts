import { WordleGame } from '@/scripts/wordleGame'

describe('Game Test', () => {
  test('is an instance', () => {
    const game = new WordleGame()
    expect(game).toBeTruthy()
  })
})
