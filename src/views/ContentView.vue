<script setup>
import CategoryCarousel from '@/components/CategoryCarousel.vue'
import { computed, watch } from 'vue'
import { useRouter, useRoute } from 'vue-router'
import oysterContent from '@/data/oysterContent.json'

const router = useRouter()
const route = useRoute()

// Get the year that the user selected
const currentYear = computed(() => route.query.year)

// Subheading
const subheading = oysterContent[currentYear.value].subheading

// Descriptions
const text1 = oysterContent[currentYear.value].content.text1
const text2 = oysterContent[currentYear.value].content.text2
const text3 = oysterContent[currentYear.value].content.text3
const text4 = oysterContent[currentYear.value].content.text4

const buttonPressToAttract = () => {
  router.push('/')
}

const buttonPressToQuiz = () => {
  router.push('/quiz')
}

console.log(currentYear.value)
console.log(oysterContent[currentYear.value].subheading)
</script>

<template>
  <div>
    <h1 @click="buttonPressToAttract">←</h1>
    <h1>{{ currentYear }}</h1>
    <h2>{{ subheading }}</h2>
    <p>{{ text1 }}</p>
    <p>{{ text2 }}</p>
    <p>{{ text3 }}</p>
    <p>{{ text4 }}</p>
    <h1 @click="buttonPressToQuiz">Go to quiz</h1>
  </div>
</template>

<style scoped></style>
