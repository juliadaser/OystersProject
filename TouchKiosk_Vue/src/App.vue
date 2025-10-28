<script setup>
import { RouterView, useRouter } from 'vue-router'

const router = useRouter()
</script>

<template>
  <div>
    <router-view v-slot="{ Component }">
      <transition name="fade">
        <component :is="Component" />
      </transition>
    </router-view>
  </div>
</template>

<style scoped></style>
