<template>
  <li class="item">{{ item }}</li>
</template>

<script>
export default {
  props: ["item"],
};
</script>

<style>
.item {
  color: red;
}
</style>
