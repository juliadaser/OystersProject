<script setup>
import CategoryCarousel from '@/components/CategoryCarousel.vue'
import { useRouter } from 'vue-router'
const router = useRouter()

const buttonPress = (year) => {
  router.push({ path: '/content', query: { year } })
}
</script>

<template>
  <div>
    <h1 @click="buttonPress(1600)">1600s</h1>
    <h1 @click="buttonPress(1715)">1715 - 1807</h1>
    <h1 @click="buttonPress(1833)">1833</h1>
    <h1 @click="buttonPress(1849)">1849 - 1906</h1>
    <h1 @click="buttonPress(1927)">1927 - 2010</h1>
    <h1 @click="buttonPress(2014)">2014 - Now</h1>
  </div>
</template>

<style scoped></style>
