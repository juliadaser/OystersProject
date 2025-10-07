<script setup>
import CategoryCarousel from '@/components/CategoryCarousel.vue'
import { useRouter } from 'vue-router'
import oysterContent from '@/data/oysterContent.json'

const router = useRouter()

const years = Object.keys(oysterContent)

const buttonPress = (year) => {
  router.push({ path: '/content', query: { year } })
}

console.log('🗓️', oysterContent)
</script>

<template>
  <div>
    <!-- Dynamically generate years from oysterContent.json -->
    <h1 v-for="year in years" :key="year" @click="buttonPress(year)">{{ year }}</h1>
  </div>
</template>

<style scoped></style>
