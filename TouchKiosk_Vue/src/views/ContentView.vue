<script setup>
import CategoryCarousel from '@/components/CategoryCarousel.vue'
import { useRouter } from 'vue-router'
const router = useRouter()

const buttonPress = () => {
  router.push('/quiz')
}
</script>

<template>
  <div>
    <h1>[Content about Oysters in year X]</h1>
    <p>
      Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut
      labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco
      laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in
      voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat
      non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
    </p>
    <h1 @click="buttonPress">Go to quiz</h1>
  </div>
</template>

<style scoped></style>
