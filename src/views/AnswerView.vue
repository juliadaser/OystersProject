<script setup>
import CategoryCarousel from '@/components/CategoryCarousel.vue'
import { useRouter } from 'vue-router'
const router = useRouter()

const buttonPress = () => {
  router.push('/')
}
</script>

<template>
  <div>
    <h1>Quiz Answer</h1>
    <CategoryCarousel></CategoryCarousel>
  </div>
  <h1 @click="buttonPress">Back</h1>
</template>

<style scoped></style>
