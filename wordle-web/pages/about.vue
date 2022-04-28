<template>
    <v-container fluid fill-height justify-center>
        <v-card-title class="text-h3 font-weight-black text-center">
            About
        </v-card-title>
        <v-card-text>
            This class project is meant to solidify the learning of front end component development using Vuetify's component. For this project we are creating a Wordle game page.
        </v-card-text>
        <v-card-text>
            Meg is a great person.
        </v-card-text>
    <v-tooltip bottom>
      <template #activator="{ on, attrs }">
        <v-btn color="primary" @click="$router.go(-1)" fab v-bind="attrs" v-on="on">
          <v-icon> mdi-arrow-left </v-icon>
        </v-btn>
      </template>
      <span> Go Back </span>
    </v-tooltip>
    
    </v-container>
</template>