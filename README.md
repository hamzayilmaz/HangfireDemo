# HangFire Demo

## Nas�l Kullan�l�r

- localhost'da **HangfireTest** adl� bir database olu�turulur.

- Projede 2 server ve 1 client bulunur.
  >- Her server Joblar� �al��t�racak servisleri temsil eder.
- Client projesinde 
  >- `/hangfire` endpointinden tan�mlanan joblar takip edilebilir.
  >- `/swagger` endpointinden Joblar tan�mlanabilir.
- Shared projesinde Joblar tan�ml�d�r, ��nk� Client ve Server servisleri aras�nda k�pr� g�revi g�r�r.
- Proje �al��t�r�ld���nda otomatik olarak 2 server ve 1 Client �al���r. Client servisinin hangfire ve swagger endpointleri a��lmal�d�r.

## Yap�lacaklar

- Herbir Server domainine �zel i�ler yap�lmas�.