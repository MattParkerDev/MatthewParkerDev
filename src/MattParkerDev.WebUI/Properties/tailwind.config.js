/** @type {import('tailwindcss').Config} */
const colors = require("tailwindcss/colors");
module.exports = {
  mode: "jit",
  content: [
    "../**/*.{razor,razor.css,css,cs,js,html}",
  ],
  theme: {
    extend: {},
  },
  plugins: [],
}
