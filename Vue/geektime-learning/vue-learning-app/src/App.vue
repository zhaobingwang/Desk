<template>
  <div id="app">
    {{ msg }}
    <div>
      <input type="text" v-model="info" />
      <button @click="handleClick">添加</button>
    </div>
    <ul>
      <todo-item v-for="item in list" :key="item" :item="item"></todo-item>
    </ul>
  </div>
</template>

<script>
// import HelloWorld from "./components/HelloWorld.vue";
import TodoItem from "./components/TodoItem.vue";

export default {
  name: "app",
  data() {
    return {
      msg: "Hello Vue",
      info: "",
      list: [],
    };
  },
  methods: {
    handleClick() {
      this.list.push(this.info);
      this.info = "";
    },
  },
  components: {
    TodoItem,
  },
};
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
