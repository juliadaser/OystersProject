<script setup>
import CategoryCarousel from '@/components/CategoryCarousel.vue'
import { useRouter } from 'vue-router'
const router = useRouter()

const buttonPress = () => {
  router.push('/answer')
}
</script>

<template>
  <div>
    <h1>Oyster Quiz</h1>
    <h1 @click="buttonPress">Find out answer</h1>
  </div>
</template>

<style scoped></style>
