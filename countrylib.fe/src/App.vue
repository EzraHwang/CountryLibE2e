<template>
  <img alt="Vue logo" src="./assets/logo.png">
  <template>
  <div>
    <h1>國家目錄</h1>
    <ul>
      <li v-for="country in countries" :key="country.name">
        {{ country.name }}
      </li>
    </ul>
  </div>
</template>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import HelloWorld from './components/HelloWorld.vue';
import axios from "Axios";

@Options({
  components: {
    HelloWorld,
  },
  data() {
    return {
      countries: <Country[]>([]),
    }
  },
})
export default class App extends Vue {
  countries!: Country[];
  async mounted() {
    const response = await axios.get("http://localhost:5074/CountryLib/Get");
    this.countries = response.data;
  }
}

interface Country {
  name: string;
  capital: string;
  region: string;
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
