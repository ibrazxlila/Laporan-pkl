const form = document.getElementById('judulForm');
const input = document.getElementById('judulInput');
const list = document.getElementById('judulList');

// Ambil dari localStorage jika ada
let judulArray = JSON.parse(localStorage.getItem('judulList')) || [];

// Tampilkan data awal
judulArray.forEach(judul => tambahJudul(judul));

// Event tambah
form.addEventListener('submit', function (e) {
    e.preventDefault();
    const judul = input.value.trim();
    if (judul !== '') {
        tambahJudul(judul);
        judulArray.push(judul);
        localStorage.setItem('judulList', JSON.stringify(judulArray));
        input.value = '';
    }
});

// Fungsi tambah ke tampilan
function tambahJudul(judul) {
    const li = document.createElement('li');
    li.textContent = judul;
    list.appendChild(li);
}
