document.addEventListener('click', function(event) {
  const button = event.target.closest('.reveal-password');
  if (!button) return;
  const input = button.closest('.input-shell')?.querySelector('input');
  if (!input) return;
  const showing = input.type === 'password';
  input.type = showing ? 'text' : 'password';
  button.setAttribute('aria-pressed', String(showing));
  button.setAttribute('aria-label', showing ? 'Ocultar contraseña' : 'Mostrar contraseña');
});
