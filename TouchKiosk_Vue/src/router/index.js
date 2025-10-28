import { createRouter, createWebHistory, useRouter } from 'vue-router'
import AttractView from '../views/AttractView.vue'
import ContentView from '../views/ContentView.vue'
import QuizView from '../views/QuizView.vue'
import AnswerView from '../views/AnswerView.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'attract',
      component: AttractView,
    },
    {
      path: '/content',
      name: 'content',
      component: ContentView,
    },
    {
      path: '/quiz',
      name: 'quiz',
      component: QuizView,
    },
    {
      path: '/answer',
      name: 'answer',
      component: AnswerView,
    },
  ],
})

export default router
