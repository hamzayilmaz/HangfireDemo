# HangFire Demo

## Nasýl Kullanýlýr

- localhost'da **HangfireTest** adlý bir database oluþturulur.

- Projede 2 server ve 1 client bulunur.
  >- Her server Joblarý çalýþtýracak servisleri temsil eder.
- Client projesinde 
  >- `/hangfire` endpointinden tanýmlanan joblar takip edilebilir.
  >- `/swagger` endpointinden Joblar tanýmlanabilir.
- Shared projesinde Joblar tanýmlýdýr, çünkü Client ve Server servisleri arasýnda köprü görevi görür.
- Proje çalýþtýrýldýðýnda otomatik olarak 2 server ve 1 Client çalýþýr. Client servisinin hangfire ve swagger endpointleri açýlmalýdýr.

## Yapýlacaklar

- Herbir Server domainine özel iþler yapýlmasý.