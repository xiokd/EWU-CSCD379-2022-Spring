
<script lang="ts">

import { defineComponent } from 'vue'
import { Component, Vue, Prop } from 'vue-property-decorator'
import { WordsService } from '~/scripts/wordsService'
import { Word } from '~/scripts/word'

@Component({})
export default class WordList extends Vue { //make word list class
    //@Prop({ required: true})
    
    static validWords(input: string): string[] { //make validWords method
        for (let index = 0; index < 5; index++) {
            if(input.includes('?')){
                input = input.replace('?', '.') //replace all placeholders with . to search match any letters
            }
        }
        let matches: string [] = []
        WordsService.#words.forEach( (element: any) => {
            if (element.match(input)){
                matches.push(element)
            }
        })
        return matches;
    }
}
</script>
