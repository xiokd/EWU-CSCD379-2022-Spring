import { Word } from "./word";
import { WordsService } from "./wordsService";

export class WordleGame {
	constructor() {
		this.currentWord = new Word();
		this.words.push(this.currentWord);
		this.word = WordsService.getRandomWord();
	}

	private word: string
	words: Word[] = []
	currentWord: Word



}
