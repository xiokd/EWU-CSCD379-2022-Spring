<template>
  <div>
    <v-btn icon @click="dialog = !dialog">
      <v-icon> mdi-cog </v-icon>
    </v-btn>

    <v-dialog v-model="dialog" width="450">
      <v-card>
        <v-container>
          <v-card-title> Settings </v-card-title>

          <v-card-text>
            <v-menu offset-y>
              <template #activator="{ on, attrs }">
                <v-btn outlined color="primary" dark v-bind="attrs" v-on="on">
                  Mode
                </v-btn>
              </template>
              <v-list>
                <v-list-item-group>
                  <v-list-item>
                    <v-list-item-title @click="lightMode"> Light </v-list-item-title>
                  </v-list-item>
                  <v-list-item>
                    <v-list-item-title> Dark </v-list-item-title>
                  </v-list-item>
                </v-list-item-group>
              </v-list>
            </v-menu>
          </v-card-text>

          <v-card-text>
            <v-menu offset-y>
              <template #activator="{ on, attrs }">
                <v-btn outlined color="primary" dark v-bind="attrs" v-on="on">
                  ColorTheme
                </v-btn>
              </template>
              <v-list>
                <v-list-item-group>
                  <v-list-item>
                    <v-list-item-title @click="purpleTheme"> purple </v-list-item-title>
                  </v-list-item>
                </v-list-item-group>
              </v-list>
            </v-menu>
          </v-card-text>
        </v-container>
      </v-card>
    </v-dialog>
  </div>
</template>

<script lang="ts">
import { Vue, Component } from 'vue-property-decorator'

@Component({ components: {} })
export default class SettingsDialog extends Vue {
  dialog = false

  lightMode(){
      this.$vuetify.theme.dark = false;
  }

  purpleTheme(){
      const purpleTheme = {
        primary: '#673AB7',
        secondary: '#9C27B0',
        error: '#F50057',
        warning: '#B388FF',
        success: '#3F51B5',
        accent: '#880E4F',
        info: '#03A9F4',
        background: '#D1C4E9',
      };

      this.$vuetify.theme.themes.light = purpleTheme;
      this.$vuetify.theme.themes.dark = purpleTheme;
  }
}
</script>
