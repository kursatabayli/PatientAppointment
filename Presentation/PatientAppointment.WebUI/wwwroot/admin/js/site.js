$(document).ready(function () {
    // Tüm userTable'ları başlat
    $('.userTable').DataTable({
        "language": {
            "url": "//cdn.datatables.net/plug-ins/1.11.3/i18n/tr.json" // Turkish language support
        }
    });

    // Tüm tablo sarmalayıcılarını gizle
    $('.userTable-container').hide();

    // Tıklanabilir başlıklar üzerinden tablo aç/kapa işlemi
    $('.clickable').click(function () {
        // Başlığın altındaki userTable-container'ı aç/kapa yap
        $(this).next('.userTable-container').fadeToggle();
        $(this).find('i').toggleClass('rotate-up rotate-down');
    });
});
