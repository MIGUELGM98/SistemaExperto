es_uso(intel_i7_9700k,gaming).
es_uso(rtx_2080_ti,gaming).
es_uso(a16_gb_o_2_de_16_gb,gaming).
es_uso(a750w_80_platino,gaming).
es_uso(asus_rog_maximus_xi_extreme,gaming).


es_gama(intel_i7_9700k,alta).
es_gama(rtx_2080_ti,alta).
es_gama(a16_gb_o_2_de_16_gb,alta).
es_gama(a750w_80_platino,alta).
es_gama(asus_rog_maximus_xi_extreme,alta).

es_uso(intel_i5_9600k,gaming).
es_uso(gtx_1060,gaming).
es_uso(a8_gb,gaming).
es_uso(a600w_80_oro,gaming).
es_uso(aorus_gaming_7,gaming).


es_gama(intel_i5_9600k,media).
es_gama(gtx_1060,media).
es_gama(a8_gb,media).
es_gama(a600w_80_oro,media).
es_gama(aorus_gaming_7,media).

es_uso(intel_i3_8100,gaming).
es_uso(gtx_1050_ti,gaming).
es_uso(a4_gb_o_16_gb,gaming).
es_uso(a500w_80_bronce,gaming).
es_uso(asus_prime,gaming).


es_gama(intel_i3_8100,baja).
es_gama(gtx_1050_ti,baja).
es_gama(a4_gb_o_16_gb,baja).
es_gama(a500w_80_bronce,baja).
es_gama(asus_prime,baja).


es_uso(i3_9100F,ofimatica).
es_uso(gt_1030,ofimatica).
es_uso(a8_gb_o_16_gb,ofimatica).
es_uso(a450w_80_bronce,ofimatica).
es_uso(gigabyte_ab350,ofimatica).

es_gama(i3_9100F,alta).
es_gama(gt_1030,alta).
es_gama(a8_gb_o_16_gb,alta).
es_gama(a450w_80_bronce,alta).
es_gama(gigabyte_ab350,alta).

es_uso(intel_pentium_g4560,ofimatica).
es_uso(gt_730,ofimatica).
es_uso(a4_gb,ofimatica).
es_uso(a400w_80_plus,ofimatica).
es_uso(gigabyte_h310m,ofimatica).

es_gama(intel_pentium_g4560,media).
es_gama(gt_730,media).
es_gama(a4_gb,media).
es_gama(a400w_80_plus,media).
es_gama(gigabyte_h310m,media).

es_uso(intel_celeron_g4920,ofimatica).
es_uso(ninguna,ofimatica).
es_uso(a2_gb,ofimatica).
es_uso(a400w_80_bronce,ofimatica).
es_uso(msi_a68hm,ofimatica).

es_gama(intel_celeron_g4920,baja).
es_gama(ninguna,baja).
es_gama(a2_gb,baja).
es_gama(a400w_80_bronce,baja).
es_gama(msi_a68hm,baja).
%PRODUCTIVIDAD


es_uso(intel_i9_9900k,productividad).
es_uso(quadro_m5000,productividad).
es_uso(a128_gb,productividad).
es_uso(a800w_80_platino,productividad).
es_uso(msi_godlike,productividad).


es_gama(intel_i9_9900k,alta).
es_gama(quadro_m5000,alta).
es_gama(a128_gb,alta).
es_gama(a800w_80_platino,alta).
es_gama(msi_godlike,alta).

es_uso(intel_i7_7700k,productividad).
es_uso(quadro_rtx4000,productividad).
es_uso(a64gb_o_32gb,productividad).
es_uso(a650w_80_oro,productividad).
es_uso(asus_rog_maximus_code,productividad).


es_gama(intel_i7_7700k,media).
es_gama(quadro_rtx4000,media).
es_gama(a64gb_o_32gb,media).
es_gama(a650w_80_oro,media).
es_gama(asus_rog_maximus_code,media).

es_uso(intel_i5_8400,productividad).
es_uso(quadro_p2000,productividad).
es_uso(a16_gb,productividad).
es_uso(a600w_80_bronce,productividad).
es_uso(prime_z390,productividad).


es_gama(intel_i5_8400,baja).
es_gama(quadro_p2000,baja).
es_gama(a16_gb,baja).
es_gama(a600w_80_bronce,baja).
es_gama(prime_z390,baja).

cargar:-exists_file('proyecto_final.pl'),consult('proyecto_final.bd').

gama_uso(X,Y,Z):-es_uso(X,Y),es_gama(X,Z).

