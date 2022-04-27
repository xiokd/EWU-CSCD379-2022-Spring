<template>
<div>
    <v-btn icon @click="rightDrawer = !rightDrawer"> 
        <v-icon> mdi-menu </v-icon> 
    </v-btn>
    <v-navigation-drawer v-model="rightDrawer" :right="right" app absolute temporary fixed>
        <v-list>
            <v-list-item
            v-for="(item, i) in items"
            :key="i"
            :to="item.to"
            router
            exact
            >
                <v-list-item-action>
                    <v-icon>{{ item.icon }}</v-icon>
                </v-list-item-action>
                <v-list-item-content>
                    <v-list-item-title v-text="item.title" />
                </v-list-item-content>
            </v-list-item>
        </v-list>
    </v-navigation-drawer>
</div>
</template>

<script lang="ts">
import { Vue, Component } from 'vue-property-decorator';

@Component({})
export default class MenuOptions extends Vue{
    data() {
        return {
            rightDrawer: false,
            right: true,
            items: [
                {
                    icon: 'mdi-information',
                    title: 'About',
                    to: '/about',
                },
            ]
        }
    }
}
</script>
