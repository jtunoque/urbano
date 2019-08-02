﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing.OSE.IService
{
    public class BillingConstant
    {

        public static Dictionary<int, string> SunatErrors =
            new Dictionary<int, string>() {
                {100,"El sistema no puede responder su solicitud. Intente nuevamente o comuníquese con su Administrador"}
                ,{101,"El encabezado de seguridad es incorrecto"}
                ,{102,"Usuario o contraseña incorrectos"}
                ,{103,"El Usuario ingresado no existe"}
                ,{104,"La Clave ingresada es incorrecta"}
                ,{105,"El Usuario no está activo"}
                ,{106,"El Usuario no es válido"}
                ,{109,"El sistema no puede responder su solicitud. (El servicio de autenticación no está disponible)"}
                ,{110,"No se pudo obtener lainformacióndel tipo de usuario"}
                ,{111,"No tiene el perfil para enviar comprobanteselectrónicos"}
                ,{112,"El usuario debe ser secundario"}
                ,{113,"El usuario noestáafiliado a FacturaElectrónica"}
                ,{125,"No se pudo obtener la constancia"}
                ,{126,"El ticket no le pertenece al usuario"}
                ,{127,"El ticket no existe"}
                ,{130,"El sistema no puede responder su solicitud. (No se pudo obtener el ticket de proceso)"}
                ,{131,"El sistema no puede responder su solicitud. (No se pudo grabar el archivo en el directorio)"}
                ,{132,"El sistema no puede responder su solicitud. (No se pudo grabar escribir en el archivo zip)"}
                ,{133,"El sistema no puede responder su solicitud. (No se pudo grabar la entrada del log)"}
                ,{134,"El sistema no puede responder su solicitud. (No se pudo grabar en el storage)"}
                ,{135,"El sistema no puede responder su solicitud. (No se pudo encolar el pedido)"}
                ,{136,"El sistema no puede responder su solicitud. (No se pudo recibir una respuesta del batch)"}
                ,{137,"El sistema no puede responder su solicitud. (Se obtuvo una respuesta nula)"}
                ,{138,"El sistema no puede responder su solicitud. (Error en Base de Datos)"}
                ,{151,"El nombre del archivo ZIP es incorrecto"}
                ,{152,"No se puede enviar por este método un archivo de resumen"}
                ,{153,"No se puede enviar por este método un archivo por lotes"}
                ,{154,"El RUC del archivo no corresponde al RUC del usuario"}
                ,{155,"El archivo ZIP estavacío"}
                ,{156,"El archivo ZIP esta corrupto"}
                ,{157,"El archivo ZIP no contiene comprobantes"}
                ,{158,"El archivo ZIP contiene demasiados comprobantes para este tipo de envío"}
                ,{159,"El nombre del archivo XML es incorrecto"}
                ,{160,"El archivo XML estavacío"}
                ,{161,"El nombre del archivo XML no coincide con el nombre del archivo ZIP"}
                ,{200,"No se pudo procesar su solicitud. (Ocurrióun error en el batch)"}
                ,{201,"No se pudo procesar su solicitud. (Llego un requerimiento nulo al batch)"}
                ,{202,"No se pudo procesar su solicitud. (No llego información del archivo ZIP)"}
                ,{203,"No se pudo procesar su solicitud. (No seencontróarchivos en lainformacióndel archivo ZIP)"}
                ,{204,"No se pudo procesar su solicitud. (Este tipo de requerimiento solo acepta 1 archivo)"}
                ,{250,"No se pudo procesar su solicitud. (Ocurrióun error desconocido al hacer unzip)"}
                ,{251,"No se pudo procesar su solicitud. (No se pudo crear un directorio para el unzip)"}
                ,{252,"No se pudo procesar su solicitud. (No seencontróarchivos dentro del zip)"}
                ,{253,"No se pudo procesar su solicitud. (No se pudo comprimir la constancia)"}
                ,{300,"No se encontró la raíz documento xml"}
                ,{301,"Elementoraízdel xml noestádefinido"}
                ,{302,"Códigodel tipo de comprobante no registrado"}
                ,{303,"No existe el directorio de schemas"}
                ,{304,"No existe el archivo de schema"}
                ,{305,"El sistema no puede procesar el archivo xml"}
                ,{306,"No se puede leer (parsear) el archivo XML"}
                ,{307,"No se pudo recuperar la constancia"}
                ,{400,"No tiene permiso para enviar casos de pruebas"}
                ,{401,"El caso de prueba no existe"}
                ,{402,"Lanumeracióno nombre del documento ya ha sido enviado anteriormente"}
                ,{403,"El documento afectado por la nota no existe"}
                ,{404,"El documento afectado por la nota se encuentra rechazado"}
                ,{1001,"ID - El dato SERIE-CORRELATIVO no cumple con el formato de acuerdo al tipo de comprobante"}
                ,{1002,"El XML no contieneinformaciónen el tag ID"}
                ,{1003,"InvoiceTypeCode - El valor del tipo de documento es invalido o no coincide con el nombre del archivo"}
                ,{1004,"El XML no contiene el tag o no existeinformaciónde InvoiceTypeCode"}
                ,{1005,"CustomerAssignedAccountID - El dato ingresado no cumple con elestándar"}
                ,{1006,"El XML no contiene el tag o no existeinformaciónde CustomerAssignedAccountID del emisor del documento"}
                ,{1007,"AdditionalAccountID - El dato ingresado no cumple con elestándar"}
                ,{1008,"El XML no contiene el tag o no existeinformaciónde AdditionalAccountID del emisor del documento"}
                ,{1009,"IssueDate - El dato ingresado no cumple con elpatrónYYYY-MM-DD"}
                ,{1010,"El XML no contiene el tag IssueDate"}
                ,{1011,"IssueDate- El dato ingresado no es valido"}
                ,{1012,"ID - El dato ingresado no cumple con elpatrónSERIE-CORRELATIVO"}
                ,{1013,"El XML no contieneinformaciónen el tag ID"}
                ,{1014,"CustomerAssignedAccountID - El dato ingresado no cumple con el estándar"}
                ,{1015,"El XML no contiene el tag o no existeinformaciónde CustomerAssignedAccountID del emisor del documento"}
                ,{1016,"AdditionalAccountID - El dato ingresado no cumple con el estándar"}
                ,{1017,"El XML no contiene el tag AdditionalAccountID del emisor del documento"}
                ,{1018,"IssueDate - El dato ingresado no cumple con elpatrónYYYY-MM-DD"}
                ,{1019,"El XML no contiene el tag IssueDate"}
                ,{1020,"IssueDate- El dato ingresado no es valido"}
                ,{1021,"Error en lavalidaciónde la nota decrédito"}
                ,{1022,"La serie onúmerodel documento modificado por la Nota Electrónica no cumple con el formato establecido"}
                ,{1023,"No se ha especificado el tipo de documento modificado por la Notaelectrónica"}
                ,{1024,"CustomerAssignedAccountID - El dato ingresado no cumple con el estándar"}
                ,{1025,"El XML no contiene el tag o no existeinformaciónde CustomerAssignedAccountID del emisor del documento"}
                ,{1026,"AdditionalAccountID - El dato ingresado no cumple con el estándar"}
                ,{1027,"El XML no contiene el tag AdditionalAccountID del emisor del documento"}
                ,{1028,"IssueDate - El dato ingresado no cumple con elpatrónYYYY-MM-DD"}
                ,{1029,"El XML no contiene el tag IssueDate"}
                ,{1030,"IssueDate- El dato ingresado no es valido"}
                ,{1031,"Error en lavalidaciónde la nota de debito"}
                ,{1032,"El comprobante fue informado previamente en unacomunicaciónde baja"}
                ,{1033,"El comprobante fue registrado previamente con otros datos"}
                ,{1034,"Número de RUC del nombre del archivo no coincide con el consignado en el contenido del archivo XML"}
                ,{1035,"Númerode Serie del nombre del archivo no coincide con el consignado en el contenido del archivo XML"}
                ,{1036,"Número de documento en el nombre del archivo no coincide con el consignado en el contenido del XML"}
                ,{1037,"El XML no contiene el tag o no existeinformaciónde RegistrationName del emisor del documento"}
                ,{1038,"RegistrationName - El nombre orazónsocial del emisor no cumple con elestándar"}
                ,{1039,"Solo se pueden recibir notaselectrónicasque modifican facturas"}
                ,{1040,"El tipo de documento modificado por la notaelectrónicano es valido"}
                ,{1041,"cac:PrepaidPayment/cbc:ID - El tag no contiene el atributo @SchemaID. que indica el tipo de documento que realiza el anticipo"}
                ,{1042,"cac:PrepaidPayment/cbc:InstructionID – El tag no contiene el atributo @SchemaID. Que indica el tipo de documento del emisor del documento del anticipo"}
                ,{1043,"cac:OriginatorDocumentReference/cbc:ID - El tag no contiene el atributo @SchemaID. Que indica el tipo de documento del originador del documento electrónico"}
                ,{1044,"cac:PrepaidPayment/cbc:InstructionID – El dato ingresado no cumple con el estándar"}
                ,{1045,"cac:OriginatorDocumentReference/cbc:ID – El dato ingresado no cumple con el estándar"}
                ,{1046,"cbc:Amount - El dato ingresado no cumple con el estándar"}
                ,{1047,"cbc:Quantity - El dato ingresado no cumple con el estándar"}
                ,{1048,"El XML no contiene el tag o no existe información de PrepaidAmount para un documento con anticipo"}
                ,{1049,"ID - Serie y Número del archivo no coincide con el consignado en el contenido del XML"}
                ,{1050,"El XML no contieneinformaciónen el tag DespatchAdviceTypeCode"}
                ,{1051,"DespatchAdviceTypeCode - El valor del tipo de guía es inválido"}
                ,{1052,"DespatchAdviceTypeCode - No coincide con el consignado en el contenido del XML"}
                ,{1053,"El XML no contieneinformaciónen el tag /DespatchAdvice/cac:OrderReference/cbc:ID"}
                ,{1054,"cac:OrderReference/cac:DocumentReference/cbc:ID - El dato SERIE-número no cumple con el formato de acuerdo a la Guía"}
                ,{1055,"Serie - No cumple con el formato de acuerdo a guía electrónica (EG01 ó TXXXX)"}
                ,{1056,"El XML no contieneinformaciónen el tag /DespatchAdvice/cac:OrderReference/cbc:OrderTypeCode"}
                ,{1057,"El XML no contiene información en el tag cac:AdditionalDocumentReference/cbc:ID"}
                ,{1058,"El XML no contiene información en el tag cac:AdditionalDocumentReference/cbc:DocumentTypeCode"}
                ,{1059,"El XML no contiene firma digital"}
                ,{1060,"El XML no contiene el tag o no existeinformacióndelnúmerode RUC del Remitente"}
                ,{1061,"Elnúmerode RUC del Remitente no existe"}
                ,{1062,"El XML no contiene el tag o no existeinformaciónen el tag /DespatchAdvice/cac:Shipment/cbc:HandlingCode"}
                ,{1063,"cbc:ShippingPriorityLevelCode: El dato ingresado no es valido"}
                ,{1064,"El XML no contiene el tag o no existe información en el tag cac:DespatchLine de bienes a transportar"}
                ,{1065,"El XML no contiene información en el tag cbc:TransportModeCode"}
                ,{1066,"El XML no contiene el tag o no existe información en el tag cac:CarrierParty de datos del transportista"}
                ,{1067,"El XML no contiene el tag o no existe información en el tag cac:TransportMeans de datos delvehículo"}
                ,{1068,"El XML no contiene el tag o no existe información en el tag cac:DriverPerson de datos del conductor"}
                ,{1069,"StartDate: El XML no contiene fecha de inicio de traslado"}
                ,{1070,"StartDate - El dato ingresado no cumple con elpatrónYYYY-MM-DD"}
                ,{1071,"StartDate - El dato ingresado no es valido"}
                ,{1072,"Starttime - El dato ingresado no cumple con elpatrónHH:mm:ss.SZ"}
                ,{1073,"StartTime - El dato ingresado no es valido"}
                ,{1074,"No ha consignado punto de llegada"}
                ,{1075,"No ha consignado punto de partida"}
                ,{2010,"El contribuyente noestáactivo"}
                ,{2011,"El contribuyente noestáhabido"}
                ,{2012,"El contribuyente no está autorizado a emitir comprobantes electrónicos"}
                ,{2013,"El contribuyente no cumple con tipo de empresa o tributos requeridos"}
                ,{2014,"El XML no contiene el tag o no existeinformaciónde CustomerAssignedAccountID del receptor del documento"}
                ,{2015,"El XML no contiene el tag o no existeinformaciónde AdditionalAccountID del receptor del documento"}
                ,{2016,"AdditionalAccountID - El dato ingresado en el tipo de documento de identidad del receptor no cumple con elestándar"}
                ,{2017,"CustomerAssignedAccountID - Elnúmerode documento de identidad delreceptordebe ser RUC"}
                ,{2018,"CustomerAssignedAccountID - El dato ingresado no cumple con el estándar"}
                ,{2019,"El XML no contiene el tag o no existeinformaciónde RegistrationName del emisor del documento"}
                ,{2020,"RegistrationName - El nombre orazónsocial del emisor no cumple con el estándar"}
                ,{2021,"El XML no contiene el tag o no existeinformaciónde RegistrationName del receptor del documento"}
                ,{2022,"RegistrationName - El dato ingresado no cumple con elestándar"}
                ,{2023,"El Numero de orden delítemno cumple con el formato establecido"}
                ,{2024,"El XML no contiene el tag InvoicedQuantity en el detalle de losÍtems"}
                ,{2025,"InvoicedQuantity El dato ingresado no cumple con elestándar"}
                ,{2026,"El XML no contiene el tag cac:Item/cbc:Description en el detalle de losÍtems"}
                ,{2027,"El XML no contiene el tag o no existeinformaciónde cac:Item/cbc:Description del item"}
                ,{2028,"Debe existir el tag cac:AlternativeConditionPrice con un elemento cbc:PriceTypeCode con valor 01"}
                ,{2029,"PriceTypeCode El dato ingresado no cumple con el estándar"}
                ,{2030,"El XML no contiene el tag cbc:PriceTypeCode"}
                ,{2031,"LineExtensionAmount El dato ingresado no cumple con el estándar"}
                ,{2032,"El XML no contiene el tag LineExtensionAmount en el detalle de los Items"}
                ,{2033,"El dato ingresado en TaxAmount de lalíneano cumple con el formato establecido"}
                ,{2034,"TaxAmount es obligatorio"}
                ,{2035,"cac:TaxCategory/cac:TaxScheme/cbc:ID El dato ingresado no cumple con elestándar"}
                ,{2036,"Elcódigodel tributo es invalido"}
                ,{2037,"El XML no contiene el tag cac:TaxCategory/cac:TaxScheme/cbc:ID del Item"}
                ,{2038,"cac:TaxScheme/cbc:Name del item - No existe el tag o el dato ingresado no cumple con elestándar"}
                ,{2039,"El XML no contiene el tag cac:TaxCategory/cac:TaxScheme/cbc:Name del Item"}
                ,{2040,"El tipo deafectacióndel IGV es incorrecto"}
                ,{2041,"El sistema decálculodel ISC es incorrecto"}
                ,{2042,"Debe indicar el IGV. Es un campo obligatorio"}
                ,{2043,"El dato ingresado en PayableAmount no cumple con el formato establecido"}
                ,{2044,"PayableAmount es obligatorio"}
                ,{2045,"El valor ingresado en AdditionalMonetaryTotal/cbc:ID es incorrecto"}
                ,{2046,"AdditionalMonetaryTotal/cbc:ID debe tener valor"}
                ,{2047,"Es obligatorio al menos un AdditionalMonetaryTotal concódigo1001, 1002 o 1003"}
                ,{2048,"El dato ingresado en TaxAmount no cumple con el formato establecido"}
                ,{2049,"TaxAmount es obligatorio"}
                ,{2050,"TaxScheme ID - No existe el tag o el dato ingresado no cumple con elestándar"}
                ,{2051,"Elcódigodel tributo es invalido"}
                ,{2052,"El XML no contiene el tag TaxScheme ID de impuestos globales"}
                ,{2053,"TaxScheme Name - No existe el tag o el dato ingresado no cumple con elestándar"}
                ,{2054,"El XML no contiene el tag TaxScheme Name de impuestos globales"}
                ,{2055,"TaxScheme TaxTypeCode - El dato ingresado no cumple con elestándar"}
                ,{2056,"El XML no contiene el tag TaxScheme TaxTypeCode de impuestos globales"}
                ,{2057,"El Name o TaxTypeCode debe corresponder con el Id para el IGV"}
                ,{2058,"El Name o TaxTypeCode debe corresponder con el Id para el ISC"}
                ,{2059,"El dato ingresado en TaxSubtotal/cbc:TaxAmount no cumple con el formato establecido"}
                ,{2060,"TaxSubtotal/cbc:TaxAmount es obligatorio"}
                ,{2061,"El tag global cac:TaxTotal/cbc:TaxAmount debe tener el mismo valor que cac:TaxTotal/cac:Subtotal/cbc:TaxAmount"}
                ,{2062,"El dato ingresado en PayableAmount no cumple con el formato establecido"}
                ,{2063,"El XML no contiene el tag PayableAmount"}
                ,{2064,"El dato ingresado en ChargeTotalAmount no cumple con el formato establecido"}
                ,{2065,"El dato ingresado enel campo Total Descuentosno cumple con el formato establecido"}
                ,{2066,"Debe indicar unadescripciónpara el tag sac:AdditionalProperty/cbc:Value"}
                ,{2067,"cac:Price/cbc:PriceAmount - El dato ingresado no cumple con elestándar"}
                ,{2068,"El XML no contiene el tag cac:Price/cbc:PriceAmount en el detalle de los Items"}
                ,{2069,"DocumentCurrencyCode - El dato ingresado no cumple con la estructura"}
                ,{2070,"El XML no contiene el tag o no existeinformaciónde DocumentCurrencyCode"}
                ,{2071,"La moneda debe ser la misma en todo el documento"}
                ,{2072,"CustomizationID - La versión del documento no es la correcta"}
                ,{2073,"El XML no contiene el tag o no existeinformaciónde CustomizationID"}
                ,{2074,"UBLVersionID - La versión del UBL no es correcta"}
                ,{2075,"El XML no contiene el tag o no existeinformaciónde UBLVersionID"}
                ,{2076,"cac:Signature/cbc:ID - Falta el identificador de la firma"}
                ,{2077,"El tag cac:Signature/cbc:ID debe contenerinformación"}
                ,{2078,"cac:Signature/cac:SignatoryParty/cac:PartyIdentification/cbc:ID - Debe ser igual al RUC del emisor"}
                ,{2079,"El XML no contiene el tag cac:Signature/cac:SignatoryParty/cac:PartyIdentification/cbc:ID"}
                ,{2080,"cac:Signature/cac:SignatoryParty/cac:PartyName/cbc:Name - No cumple con elestándar"}
                ,{2081,"El XML no contiene el tag cac:Signature/cac:SignatoryParty/cac:PartyName/cbc:Name"}
                ,{2082,"cac:Signature/cac:DigitalSignatureAttachment/cac:ExternalReference/cbc:URI - No cumple con elestándar"}
                ,{2083,"El XML no contiene el tag cac:Signature/cac:DigitalSignatureAttachment/cac:ExternalReference/cbc:URI"}
                ,{2084,"ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent/ds:Signature/@Id - No cumple con elestándar"}
                ,{2085,"El XML no contiene el tag ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent/ds:Signature/@Id"}
                ,{2086,"ext:UBLExtensions/.../ds:Signature/ds:SignedInfo/ds:CanonicalizationMethod/@Algorithm - No cumple con elestándar"}
                ,{2087,"El XML no contiene el tag ext:UBLExtensions/.../ds:Signature/ds:SignedInfo/ds:CanonicalizationMethod/@Algorithm"}
                ,{2088,"ext:UBLExtensions/.../ds:Signature/ds:SignedInfo/ds:SignatureMethod/@Algorithm - No cumple con elestándar"}
                ,{2089,"El XML no contiene el tag ext:UBLExtensions/.../ds:Signature/ds:SignedInfo/ds:SignatureMethod/@Algorithm"}
                ,{2090,"ext:UBLExtensions/.../ds:Signature/ds:SignedInfo/ds:Reference/@URI - Debe estarvacíopara id"}
                ,{2091,"El XML no contiene el tag ext:UBLExtensions/.../ds:Signature/ds:SignedInfo/ds:Reference/@URI"}
                ,{2092,"ext:UBLExtensions/.../ds:Signature/ds:SignedInfo/.../ds:Transform@Algorithm - No cumple con elestándar"}
                ,{2093,"El XML no contiene el tag ext:UBLExtensions/.../ds:Signature/ds:SignedInfo/ds:Reference/ds:Transform@Algorithm"}
                ,{2094,"ext:UBLExtensions/.../ds:Signature/ds:SignedInfo/ds:Reference/ds:DigestMethod/@Algorithm - No cumple con elestándar"}
                ,{2095,"El XML no contiene el tag ext:UBLExtensions/.../ds:Signature/ds:SignedInfo/ds:Reference/ds:DigestMethod/@Algorithm"}
                ,{2096,"ext:UBLExtensions/.../ds:Signature/ds:SignedInfo/ds:Reference/ds:DigestValue - No cumple con elestándar"}
                ,{2097,"El XML no contiene el tag ext:UBLExtensions/.../ds:Signature/ds:SignedInfo/ds:Reference/ds:DigestValue"}
                ,{2098,"ext:UBLExtensions/.../ds:Signature/ds:SignatureValue - No cumple con elestándar"}
                ,{2099,"El XML no contiene el tag ext:UBLExtensions/.../ds:Signature/ds:SignatureValue"}
                ,{2100,"ext:UBLExtensions/.../ds:Signature/ds:KeyInfo/ds:X509Data/ds:X509Certificate - No cumple con elestándar"}
                ,{2101,"El XML no contiene el tag ext:UBLExtensions/.../ds:Signature/ds:KeyInfo/ds:X509Data/ds:X509Certificate"}
                ,{2102,"Error al procesar la factura"}
                ,{2103,"La serie ingresada no es válida"}
                ,{2104,"Numero de RUC del emisor no existe"}
                ,{2105,"Factura a dar de baja no se encuentra registrada en SUNAT"}
                ,{2106,"Factura a dar de baja ya se encuentra en estado de baja"}
                ,{2107,"Numero de RUC SOL no coincide con RUC emisor"}
                ,{2108,"Presentación fuera de fecha"}
                ,{2109,"El comprobante fue registrado previamente con otros datos"}
                ,{2110,"UBLVersionID - La versión del UBL no es correcta"}
                ,{2111,"El XML no contiene el tag o no existeinformaciónde UBLVersionID"}
                ,{2112,"CustomizationID - Laversióndel documento no es correcta"}
                ,{2113,"El XML no contiene el tag o no existeinformaciónde CustomizationID"}
                ,{2114,"DocumentCurrencyCode - El dato ingresado no cumple con la estructura"}
                ,{2115,"El XML no contiene el tag o no existeinformaciónde DocumentCurrencyCode"}
                ,{2116,"El tipo de documento modificado por la Nota decréditodebe ser facturaelectrónicao ticket"}
                ,{2117,"La serie onúmerodel documento modificado por la Nota deCréditono cumple con el formato establecido"}
                ,{2118,"Debe indicar las facturas relacionadas a la Nota deCrédito"}
                ,{2119,"La factura relacionada en la Nota decréditonoestáregistrada."}
                ,{2120,"La factura relacionada en la nota decréditose encuentra de baja"}
                ,{2121,"La factura relacionada en la nota decréditoestáregistrada como rechazada"}
                ,{2122,"El tag cac:LegalMonetaryTotal/cbc:PayableAmount debe tenerinformaciónvalida"}
                ,{2123,"RegistrationName - El dato ingresado no cumple con elestándar"}
                ,{2124,"El XML no contiene el tag RegistrationName del emisor del documento"}
                ,{2125,"ReferenceID - El dato ingresado debe indicar SERIE-CORRELATIVO del documento al que se relaciona la Nota"}
                ,{2126,"El XML no contieneinformaciónen el tag ReferenceID del documento al que se relaciona la nota"}
                ,{2127,"ResponseCode - El dato ingresado no cumple con la estructura"}
                ,{2128,"El XML no contiene el tag o no existeinformaciónde ResponseCode"}
                ,{2129,"AdditionalAccountID - El dato ingresado en el tipo de documento de identidad del receptor no cumple con elestándar"}
                ,{2130,"El XML no contiene el tag o no existeinformaciónde AdditionalAccountID del receptor del documento"}
                ,{2131,"CustomerAssignedAccountID - El número de documento de identidad del receptor debe ser RUC"}
                ,{2132,"El XML no contiene el tag o no existeinformaciónde CustomerAssignedAccountID del receptor del documento"}
                ,{2133,"RegistrationName - El dato ingresado no cumple con elestándar"}
                ,{2134,"El XML no contiene el tag o no existeinformaciónde RegistrationName del receptor del documento"}
                ,{2135,"cac:DiscrepancyResponse/cbc:Description - El dato ingresado no cumple con la estructura"}
                ,{2136,"El XML no contiene el tag o no existeinformaciónde cac:DiscrepancyResponse/cbc:Description"}
                ,{2137,"El Número de orden delítemno cumple con el formato establecido"}
                ,{2138,"CreditedQuantity/@unitCode - El dato ingresado no cumple con elestándar"}
                ,{2139,"CreditedQuantity - El dato ingresado no cumple con elestándar"}
                ,{2140,"El PriceTypeCode debe tener el valor 01"}
                ,{2141,"cac:TaxCategory/cac:TaxScheme/cbc:ID - El dato ingresado no cumple con elestándar"}
                ,{2142,"Elcódigodel tributo es invalido"}
                ,{2143,"cac:TaxScheme/cbc:Name delítem- No existe el tag o el dato ingresado no cumple con elestándar"}
                ,{2144,"cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode El dato ingresado no cumple con elestándar"}
                ,{2145,"El tipo deafectacióndel IGV es incorrecto"}
                ,{2146,"El Nombre Internacional debe ser VAT"}
                ,{2147,"El sistema decálculodel ISC es incorrecto"}
                ,{2148,"El Nombre Internacional debe ser EXC"}
                ,{2149,"El dato ingresado en PayableAmount no cumple con el formato establecido"}
                ,{2150,"El valor ingresado en AdditionalMonetaryTotal/cbc:ID es incorrecto"}
                ,{2151,"AdditionalMonetaryTotal/cbc:ID debe tener valor"}
                ,{2152,"Es obligatorio al menos un AdditionalInformation"}
                ,{2153,"Error al procesar la Nota deCrédito"}
                ,{2154,"TaxAmount - El dato ingresado en impuestos globales no cumple con elestándar"}
                ,{2155,"El XML no contiene el tag TaxAmount de impuestos globales"}
                ,{2156,"TaxScheme ID - El dato ingresado no cumple con elestándar"}
                ,{2157,"Elcódigodel tributo es invalido"}
                ,{2158,"El XML no contiene el tag o no existeinformaciónde TaxScheme ID de impuestos globales"}
                ,{2159,"TaxScheme Name - El dato ingresado no cumple con elestándar"}
                ,{2160,"El XML no contiene el tag o no existeinformaciónde TaxScheme Name de impuestos globales"}
                ,{2161,"CustomizationID - Laversióndel documento no es correcta"}
                ,{2162,"El XML no contiene el tag o no existeinformaciónde CustomizationID"}
                ,{2163,"UBLVersionID - La versión del UBL no es correcta"}
                ,{2164,"El XML no contiene el tag o no existeinformaciónde UBLVersionID"}
                ,{2165,"Error al procesar la Nota de Debito"}
                ,{2166,"RegistrationName - El dato ingresado no cumple con elestándar"}
                ,{2167,"El XML no contiene el tag RegistrationName del emisor del documento"}
                ,{2168,"DocumentCurrencyCode - El dato ingresado no cumple con el formato establecido"}
                ,{2169,"El XML no contiene el tag o no existeinformaciónde DocumentCurrencyCode"}
                ,{2170,"ReferenceID - El dato ingresado debe indicar SERIE-CORRELATIVO del documento al que se relaciona la Nota"}
                ,{2171,"El XML no contieneinformaciónen el tag ReferenceID del documento al que se relaciona la nota"}
                ,{2172,"ResponseCode - El dato ingresado no cumple con la estructura"}
                ,{2173,"El XML no contiene el tag o no existeinformaciónde ResponseCode"}
                ,{2174,"cac:DiscrepancyResponse/cbc:Description - El dato ingresado no cumple con la estructura"}
                ,{2175,"El XML no contiene el tag o no existeinformaciónde cac:DiscrepancyResponse/cbc:Description"}
                ,{2176,"AdditionalAccountID - El dato ingresado en el tipo de documento de identidad del receptor no cumple con elestándar"}
                ,{2177,"El XML no contiene el tag o no existeinformaciónde AdditionalAccountID del receptor del documento"}
                ,{2178,"CustomerAssignedAccountID - Elnúmerode documento de identidad del receptor debe ser RUC."}
                ,{2179,"El XML no contiene el tag o no existeinformaciónde CustomerAssignedAccountID del receptor del documento"}
                ,{2180,"RegistrationName - El dato ingresado no cumple con elestándar"}
                ,{2181,"El XML no contiene el tag o no existeinformaciónde RegistrationName del receptor del documento"}
                ,{2182,"TaxScheme ID - El dato ingresado no cumple con elestándar"}
                ,{2183,"Elcódigodel tributo es invalido"}
                ,{2184,"El XML no contiene el tag o no existeinformaciónde TaxScheme ID de impuestos globales"}
                ,{2185,"TaxScheme Name - El dato ingresado no cumple con elestándar"}
                ,{2186,"El XML no contiene el tag o no existeinformaciónde TaxScheme Name de impuestos globales"}
                ,{2187,"El Numero de orden delítemno cumple con el formato establecido"}
                ,{2188,"DebitedQuantity/@unitCode El dato ingresado no cumple con elestándar"}
                ,{2189,"DebitedQuantity El dato ingresado no cumple con elestándar"}
                ,{2190,"El XML no contiene el tag Price/cbc:PriceAmount en el detalle de los Items"}
                ,{2191,"El XML no contiene el tag Price/cbc:LineExtensionAmount en el detalle de los Items"}
                ,{2192,"EL PriceTypeCode debe tener el valor 01"}
                ,{2193,"cac:TaxCategory/cac:TaxScheme/cbc:ID El dato ingresado no cumple con elestándar"}
                ,{2194,"Elcódigodel tributo es invalido"}
                ,{2195,"cac:TaxScheme/cbc:Name del item - No existe el tag o el dato ingresado no cumple con elestándar"}
                ,{2196,"cac:TaxCategory/cac:TaxScheme/cbc:TaxTypeCode El dato ingresado no cumple con elestándar"}
                ,{2197,"El tipo deafectacióndel IGV es incorrecto"}
                ,{2198,"El Nombre Internacional debe ser VAT"}
                ,{2199,"El sistema decálculodel ISC es incorrecto"}
                ,{2200,"El Nombre Internacional debe ser EXC"}
                ,{2201,"El tag cac:RequestedMonetaryTotal/cbc:PayableAmount debe tenerinformaciónvalida"}
                ,{2202,"TaxAmount - El dato ingresado en impuestos globales no cumple con el estándar"}
                ,{2203,"El XML no contiene el tag TaxAmount de impuestos globales"}
                ,{2204,"El tipo de documento modificado por la Nota de Debito debe ser facturaelectrónicao ticket"}
                ,{2205,"La serie onúmerodel documento modificado por la Nota de Debito no cumple con el formato establecido"}
                ,{2206,"Debe indicar los documentos afectados por la Nota de Debito"}
                ,{2207,"La factura relacionada en la nota dedébitose encuentra de baja"}
                ,{2208,"La factura relacionada en la nota dedébitoestáregistrada como rechazada"}
                ,{2209,"La factura relacionada en la Nota dedébitonoestáregistrada"}
                ,{2210,"El dato ingresado no cumple con el formato RC-fecha-correlativo"}
                ,{2211,"El XML no contiene el tag ID"}
                ,{2212,"UBLVersionID - La versión del UBL del resumen de boletas no es correcta"}
                ,{2213,"El XML no contiene el tag UBLVersionID"}
                ,{2214,"CustomizationID - La versión del resumen de boletas no es correcta"}
                ,{2215,"El XML no contiene el tag CustomizationID"}
                ,{2216,"CustomerAssignedAccountID - El dato ingresado no cumple con elestándar"}
                ,{2217,"El XML no contiene el tag CustomerAssignedAccountID del emisor del documento"}
                ,{2218,"AdditionalAccountID - El dato ingresado no cumple con elestándar"}
                ,{2219,"El XML no contiene el tag AdditionalAccountID del emisor del documento"}
                ,{2220,"El ID debe coincidir con el nombre del archivo"}
                ,{2221,"El RUC debe coincidir con el RUC del nombre del archivo"}
                ,{2222,"El contribuyente no está autorizado a emitir comprobanteselectrónicos"}
                ,{2223,"El archivo ya fue presentado anteriormente"}
                ,{2224,"Numero de RUC SOL no coincide con RUC emisor"}
                ,{2225,"Numero de RUC del emisor no existe"}
                ,{2226,"El contribuyente noestáactivo"}
                ,{2227,"El contribuyente no cumple con tipo de empresa o tributos requeridos"}
                ,{2228,"RegistrationName - El dato ingresado no cumple con elestándar"}
                ,{2229,"El XML no contiene el tag RegistrationName del emisor del documento"}
                ,{2230,"IssueDate - El dato ingresado no cumple con elpatrónYYYY-MM-DD"}
                ,{2231,"El XML no contiene el tag IssueDate"}
                ,{2232,"IssueDate- El dato ingresado no es valido"}
                ,{2233,"ReferenceDate - El dato ingresado no cumple con elpatrónYYYY-MM-DD"}
                ,{2234,"El XML no contiene el tag ReferenceDate"}
                ,{2235,"ReferenceDate- El dato ingresado no es valido"}
                ,{2236,"La fecha del IssueDate no debe ser mayor al Today"}
                ,{2237,"La fecha del ReferenceDate no debe ser mayor al Today"}
                ,{2238,"LineID - El dato ingresado no cumple con elestándar"}
                ,{2239,"LineID - El dato ingresado debe ser correlativo mayor a cero"}
                ,{2240,"El XML no contiene el tag LineID de SummaryDocumentsLine"}
                ,{2241,"DocumentTypeCode - El valor del tipo de documento es invalido"}
                ,{2242,"El XML no contiene el tag DocumentTypeCode"}
                ,{2243,"El dato ingresado no cumple con elpatrónSERIE"}
                ,{2244,"El XML no contiene el tag DocumentSerialID"}
                ,{2245,"El dato ingresado en StartDocumentNumberID debe sernumérico"}
                ,{2246,"El XML no contiene el tag StartDocumentNumberID"}
                ,{2247,"El dato ingresado en sac:EndDocumentNumberID debe sernumérico"}
                ,{2248,"El XML no contiene el tag sac:EndDocumentNumberID"}
                ,{2249,"Los rangos deben ser mayores a cero"}
                ,{2250,"En el rango de comprobantes, el EndDocumentNumberID debe ser mayor o igual al StartInvoiceNumberID"}
                ,{2251,"El dato ingresado en TotalAmount debe sernuméricomayor o igual a cero"}
                ,{2252,"El XML no contiene el tag TotalAmount"}
                ,{2253,"El dato ingresado en TotalAmount debe sernuméricomayor a cero"}
                ,{2254,"PaidAmount - El dato ingresado no cumple con elestándar"}
                ,{2255,"El XML no contiene el tag PaidAmount"}
                ,{2256,"InstructionID - El dato ingresado no cumple con elestándar"}
                ,{2257,"El XML no contiene el tag InstructionID"}
                ,{2258,"Debe indicar Referencia de Importes asociados a las boletas de venta"}
                ,{2259,"Debe indicar 3 Referencias de Importes asociados a las boletas de venta"}
                ,{2260,"PaidAmount - El dato ingresado debe ser mayor o igual a 0.00"}
                ,{2261,"cbc:Amount - El dato ingresado no cumple con elestándar"}
                ,{2262,"El XML no contiene el tag cbc:Amount"}
                ,{2263,"ChargeIndicator - El dato ingresado no cumple con elestándar"}
                ,{2264,"El XML no contiene el tag ChargeIndicator"}
                ,{2265,"Debe indicar Información acerca del Importe Total de Otros Cargos"}
                ,{2266,"Debe indicar cargos mayores o iguales a cero"}
                ,{2267,"TaxScheme ID - El dato ingresado no cumple con elestándar"}
                ,{2268,"Elcódigodel tributo es invalido"}
                ,{2269,"El XML no contiene el tag TaxScheme ID de Información acerca del importe total de un tipo particular de impuesto"}
                ,{2270,"TaxScheme Name - El dato ingresado no cumple con elestándar"}
                ,{2271,"El XML no contiene el tag TaxScheme Name de impuesto"}
                ,{2272,"TaxScheme TaxTypeCode - El dato ingresado no cumple con elestándar"}
                ,{2273,"TaxAmount - El dato ingresado no cumple con elestándar"}
                ,{2274,"El XML no contiene el tag TaxAmount"}
                ,{2275,"Si elcódigode tributo es 2000, el nombre del tributo debe ser ISC"}
                ,{2276,"Si elcódigode tributo es 1000, el nombre del tributo debe ser IGV"}
                ,{2277,"No se ha consignado ningunainformacióndel importe total de tributos"}
                ,{2278,"Debe indicar Información acerca del importe total de ISC e IGV"}
                ,{2279,"Debe indicar Items de consolidado de documentos"}
                ,{2280,"Existen problemas con lainformacióndel resumen de comprobantes"}
                ,{2281,"Error en lavalidaciónde los rangos de los comprobantes"}
                ,{2282,"Existe documento ya informado anteriormente"}
                ,{2283,"El dato ingresado no cumple con el formato RA-fecha-correlativo"}
                ,{2284,"El XML no contiene el tag ID"}
                ,{2285,"El ID debe coincidir con el nombre del archivo"}
                ,{2286,"El RUC debe coincidir con el RUC del nombre del archivo"}
                ,{2287,"AdditionalAccountID - El dato ingresado no cumple con elestándar"}
                ,{2288,"El XML no contiene el tag AdditionalAccountID del emisor del documento"}
                ,{2289,"CustomerAssignedAccountID - El dato ingresado no cumple con el estándar"}
                ,{2290,"El XML no contiene el tag CustomerAssignedAccountID del emisor del documento"}
                ,{2291,"El contribuyente noestáautorizado a emitir comprobantes electrónicos"}
                ,{2292,"Numero de RUC SOL no coincide con RUC emisor"}
                ,{2293,"Numero de RUC del emisor no existe"}
                ,{2294,"El contribuyente noestáactivo"}
                ,{2295,"El contribuyente no cumple con tipo de empresa o tributos requeridos"}
                ,{2296,"RegistrationName - El dato ingresado no cumple con elestándar"}
                ,{2297,"El XML no contiene el tag RegistrationName del emisor del documento"}
                ,{2298,"IssueDate - El dato ingresado no cumple con elpatrónYYYY-MM-DD"}
                ,{2299,"El XML no contiene el tag IssueDate"}
                ,{2300,"IssueDate - El dato ingresado no es valido"}
                ,{2301,"La fecha del IssueDate no debe ser mayor al Today"}
                ,{2302,"ReferenceDate - El dato ingresado no cumple con elpatrónYYYY-MM-DD"}
                ,{2303,"El XML no contiene el tag ReferenceDate"}
                ,{2304,"ReferenceDate - El dato ingresado no es valido"}
                ,{2305,"LineID - El dato ingresado no cumple con elestándar"}
                ,{2306,"LineID - El dato ingresado debe ser correlativo mayor a cero"}
                ,{2307,"El XML no contiene el tag LineID de VoidedDocumentsLine"}
                ,{2308,"DocumentTypeCode - El valor del tipo de documento es invalido"}
                ,{2309,"El XML no contiene el tag DocumentTypeCode"}
                ,{2310,"El dato ingresado no cumple con elpatrónSERIE"}
                ,{2311,"El XML no contiene el tag DocumentSerialID"}
                ,{2312,"El dato ingresado en DocumentNumberID debe sernuméricoy comomáximode 8dígitos"}
                ,{2313,"El XML no contiene el tag DocumentNumberID"}
                ,{2314,"El dato ingresado en VoidReasonDescription debe contener información válida"}
                ,{2315,"El XML no contiene el tag VoidReasonDescription"}
                ,{2316,"Debe indicar Items en VoidedDocumentsLine"}
                ,{2317,"Error al procesar el resumen de anulados"}
                ,{2318,"CustomizationID - Laversióndel documento no es correcta"}
                ,{2319,"El XML no contiene el tag CustomizationID"}
                ,{2320,"UBLVersionID - Laversióndel UBL no es la correcta"}
                ,{2321,"El XML no contiene el tag UBLVersionID"}
                ,{2322,"Error en lavalidaciónde los rangos"}
                ,{2323,"Existe documento ya informado anteriormente en unacomunicaciónde baja"}
                ,{2324,"El archivo decomunicaciónde baja ya fue presentado anteriormente"}
                ,{2325,"El certificado usado no es el comunicado a SUNAT"}
                ,{2326,"El certificado usado se encuentra de baja"}
                ,{2327,"El certificado usado no se encuentra vigente"}
                ,{2328,"El certificado usado se encuentra revocado"}
                ,{2329,"La fecha deemisiónse encuentra fuera dellímitepermitido"}
                ,{2330,"La fecha de generación de la comunicación debe ser igual a la fecha consignada en el nombre del archivo"}
                ,{2331,"Número de RUC del nombre del archivo no coincide con el consignado en el contenido del archivo XML"}
                ,{2332,"Número de Serie del nombre del archivo no coincide con el consignado en el contenido del archivo XML"}
                ,{2333,"Número de documento en el nombre del archivo no coincide con el consignado en el contenido del XML"}
                ,{2334,"El documento electrónico ingresado ha sido alterado"}
                ,{2335,"El documento electrónico ingresado ha sido alterado"}
                ,{2336,"Ocurrió un error en el proceso de validación de la firma digital"}
                ,{2337,"La moneda debe ser la misma en todo el documento"}
                ,{2338,"La moneda debe ser la misma en todo el documento"}
                ,{2339,"El dato ingresado en PayableAmount no cumple con el formato establecido"}
                ,{2340,"El valor ingresado en AdditionalMonetaryTotal/cbc:ID es incorrecto"}
                ,{2341,"AdditionalMonetaryTotal/cbc:ID debe tener valor"}
                ,{2342,"Fecha deemisiónde la factura no coincide con la informada en lacomunicación"}
                ,{2343,"cac:TaxTotal/cac:TaxSubtotal/cbc:TaxAmount - El dato ingresado no cumple con elestándar"}
                ,{2344,"El XML no contiene el tag cac:TaxTotal/cac:TaxSubtotal/cbc:TaxAmount"}
                ,{2345,"La serie no corresponde al tipo de comprobante"}
                ,{2346,"La fecha de generación del resumen debe ser igual a la fecha consignada en el nombre del archivo"}
                ,{2347,"Los rangos informados en el archivo XML se encuentran duplicados o superpuestos"}
                ,{2348,"Los documentos informados en el archivo XML se encuentran duplicados"}
                ,{2349,"Debe consignar solo un elemento sac:AdditionalMonetaryTotal con cbc:ID igual a 1001"}
                ,{2350,"Debe consignar solo un elemento sac:AdditionalMonetaryTotal con cbc:ID igual a 1002"}
                ,{2351,"Debe consignar solo un elemento sac:AdditionalMonetaryTotal con cbc:ID igual a 1003"}
                ,{2352,"Debe consignar solo un elemento cac:TaxTotal a nivel global para IGV (cbc:ID igual a 1000)"}
                ,{2353,"Debe consignar solo un elemento cac:TaxTotal a nivel global para ISC (cbc:ID igual a 2000)"}
                ,{2354,"Debe consignar solo un elemento cac:TaxTotal a nivel global para Otros (cbc:ID igual a 9999)"}
                ,{2355,"Debe consignar solo un elemento cac:TaxTotal a nivel deítempara IGV (cbc:ID igual a 1000)"}
                ,{2356,"Debe consignar solo un elemento cac:TaxTotal a nivel deítempara ISC (cbc:ID igual a 2000)"}
                ,{2357,"Debe consignar solo un elemento sac:BillingPayment a nivel deítemcon cbc:InstructionID igual a 01"}
                ,{2358,"Debe consignar solo un elemento sac:BillingPayment a nivel deítemcon cbc:InstructionID igual a 02"}
                ,{2359,"Debe consignar solo un elemento sac:BillingPayment a nivel deítemcon cbc:InstructionID igual a 03"}
                ,{2360,"Debe consignar solo un elemento sac:BillingPayment a nivel deítemcon cbc:InstructionID igual a 04"}
                ,{2361,"Debe consignar solo un elemento cac:TaxTotal a nivel deítempara Otros (cbc:ID igual a 9999)"}
                ,{2362,"Debeconsignarsolo un tagcac:AccountingSupplierParty/cbc:AdditionalAccountID"}
                ,{2363,"Debe consignar solo un tag cac:AccountingCustomerParty/cbc:AdditionalAccountID"}
                ,{2364,"El comprobante contiene un tipo y número de Guía de Remisión repetido"}
                ,{2365,"El comprobante contiene un tipo y número de Documento Relacionado repetido"}
                ,{2366,"Elcódigoen el tag sac:AdditionalProperty/cbc:ID debe tener 4 posiciones"}
                ,{2367,"El dato ingresado en PriceAmount del Precio de venta unitario por item no cumple con el formato establecido"}
                ,{2368,"El dato ingresado en TaxSubtotal/cbc:TaxAmount del item no cumple con el formato establecido"}
                ,{2369,"El dato ingresado en PriceAmount del Valor de venta unitario por item no cumple con el formato establecido"}
                ,{2370,"El dato ingresado en LineExtensionAmount del item no cumple con el formato establecido"}
                ,{2371,"El XML no contiene el tag cbc:TaxExemptionReasonCode de Afectacion al IGV"}
                ,{2372,"El tag en el item cac:TaxTotal/cbc:TaxAmount debe tener el mismo valor que cac:TaxTotal/cac:TaxSubtotal/cbc:TaxAmount"}
                ,{2373,"Si existe monto de ISC en el ITEM debe especificar el sistema de cálculo"}
                ,{2374,"La factura a dar de baja tiene una fecha de recepción fuera del plazo permitido"}
                ,{2375,"Fecha de emisión de la boleta no coincide con la fecha de emisión consignada en lacomunicación"}
                ,{2376,"La boleta de venta a dar de baja fue informada en un resumen con fecha derecepciónfuera del plazo permitido"}
                ,{2377,"El Name o TaxTypeCode debe corresponder con el Id para el IGV"}
                ,{2378,"El Name o TaxTypeCode debe corresponder con el Id para el ISC"}
                ,{2379,"Lanumeraciónde boleta de venta a dar de baja fue generada en una fecha fuera del plazo permitido"}
                ,{2380,"El documento tiene observaciones"}
                ,{2381,"Comprobante no cumple con el Grupo 1: No todos losítemscorresponden a operaciones gravadas a IGV"}
                ,{2382,"Comprobante no cumple con el Grupo 2: No todos losítems corresponden a operaciones inafectas o exoneradas al IGV"}
                ,{2383,"Comprobante no cumple con el Grupo 3: Falta leyenda concódigo1002"}
                ,{2384,"Comprobante no cumple con el Grupo 3: Existeítemcon operación onerosa"}
                ,{2385,"Comprobante no cumple con el Grupo 4: DebeexistirTotal descuentos mayor a cero"}
                ,{2386,"Comprobante no cumple con el Grupo 5: Todos losítemsdeben tener operaciones afectas a ISC"}
                ,{2387,"Comprobante no cumple con el Grupo 6: El monto depercepciónno existe o es cero"}
                ,{2388,"Comprobante no cumple con el Grupo 6: Todos losítemsdeben tener código de Afectación al IGV igual a 10"}
                ,{2389,"Comprobante no cumple con el Grupo 7: Elcódigode moneda no es diferente a PEN"}
                ,{2390,"Comprobante no cumple con el Grupo 8: No todos losítemscorresponden a operaciones gravadas a IGV"}
                ,{2391,"Comprobante no cumple con el Grupo 9: No todos losítemscorresponden a operaciones inafectas o exoneradas al IGV"}
                ,{2392,"Comprobante no cumple con el Grupo 10: Falta leyenda concódigo1002"}
                ,{2393,"Comprobante no cumple con el Grupo 10: Existeítemcon operación onerosa"}
                ,{2394,"Comprobante no cumple con el Grupo 11: Debe existir Total descuentos mayor a cero"}
                ,{2395,"Comprobante no cumple con el Grupo 12: Elcódigode moneda no es diferente a PEN"}
                ,{2396,"Si el monto total es mayor a S/. 700.00 debe consignar tipo y numero de documento del adquiriente"}
                ,{2397,"El tipo de documento del adquiriente no puede ser Numero de RUC"}
                ,{2398,"El documento a dar de baja se encuentra rechazado"}
                ,{2399,"El tipo de documento modificado por la Nota decréditodebe ser boletaelectrónica"}
                ,{2400,"El tipo de documento modificado por la Nota dedébitodebe ser boletaelectrónica"}
                ,{2401,"No se puede leer (parsear) el archivo XML"}
                ,{2402,"El caso de prueba no existe"}
                ,{2403,"Lanumeracióno nombre del documento ya ha sido enviado anteriormente"}
                ,{2404,"Documento afectado por la notaelectrónicano se encuentra autorizado"}
                ,{2405,"Contribuyente no se encuentra autorizado como emisor de boletaselectrónicas"}
                ,{2406,"Existemásde un tag sac:AdditionalMonetaryTotal con el mismo ID"}
                ,{2407,"Existemásde un tag sac:AdditionalProperty con el mismo ID"}
                ,{2408,"El dato ingresado en PriceAmount del Valor referencial unitario porítemno cumple con el formato establecido"}
                ,{2409,"Existemásde un tag cac:AlternativeConditionPrice con el mismo cbc:PriceTypeCode"}
                ,{2410,"Se ha consignado un valor invalido en el campo cbc:PriceTypeCode"}
                ,{2411,"Ha consignadomásde un elemento cac:AllowanceCharge con el mismo campo cbc:ChargeIndicator"}
                ,{2412,"Se ha consignadomásde un documento afectado por la nota (tag cac:BillingReference)"}
                ,{2413,"Se ha consignadomásde un motivo o sustento de la nota (tag cac:DiscrepancyResponse/cbc:Description)"}
                ,{2414,"No se ha consignado en la nota el tag cac:DiscrepancyResponse"}
                ,{2415,"Se ha consignado en la notamásde un tag cac:DiscrepancyResponse"}
                ,{2416,"Si existe leyenda Transferida Gratuita debe consignar Total Valor de Venta de Operaciones Gratuitas"}
                ,{2417,"Debe consignar Valor Referencial unitario por ítem en operaciones no onerosas"}
                ,{2418,"Si consigna Valor Referencial unitario por ítem en operaciones no onerosas, la operación debe ser no onerosa"}
                ,{2419,"El dato ingresado en AllowanceTotalAmount no cumple con el formato establecido"}
                ,{2420,"Ya transcurrieronmásde 25díascalendarios para concluir con su proceso dehomologación"}
                ,{2421,"Debe indicar toda lainformaciónde sustento detrasladode bienes"}
                ,{2422,"El valor unitario debe ser menor al precio unitario"}
                ,{2423,"Si ha consignado monto ISC a nivel deítem, debe consignar un monto a nivel de total"}
                ,{2424,"RC Debe consignar solo un elemento sac:BillingPayment a nivel deítemcon cbc:InstructionID igual a 05"}
                ,{2425,"Si laoperaciónes gratuita PriceTypeCode =02 y cbc:PriceAmount> 0 elcódigodeafectaciónde igv debe ser no onerosa es decir diferente de 10,20,30"}
                ,{2426,"Documentos relacionados duplicados en el comprobante"}
                ,{2427,"Solo debe de existir un tag AdditionalInformation"}
                ,{2428,"Comprobante no cumple con grupo de facturas con detracciones"}
                ,{2429,"Comprobante no cumple con grupo de facturas con comercio exterior"}
                ,{2430,"Comprobante no cumple con grupo de facturas con tag de facturaguía"}
                ,{2431,"Comprobante no cumple con grupo de facturas con tags no tributarios"}
                ,{2432,"Comprobante no cumple con grupo de boletas con tags no tributarios"}
                ,{2433,"Comprobante no cumple con grupo de facturas con tag venta itinerante"}
                ,{2434,"Comprobante no cumple con grupo de boletas con tag venta itinerante"}
                ,{2435,"Comprobante no cumple con grupo de boletas con ISC"}
                ,{2436,"Comprobante no cumple con el grupo de boletas de venta conpercepción: El monto depercepciónno existe o es cero"}
                ,{2437,"Comprobante no cumple con el grupo de boletas de venta conpercepción: Todos losítemsdeben tener código de Afectación al IGV igual a 10"}
                ,{2438,"Comprobante no cumple con grupo de facturas con tag venta anticipada I"}
                ,{2439,"Comprobante no cumple con grupo de facturas con tag venta anticipada II"}
                ,{2500,"Ingresar descripción y valor venta por ítem para documento de anticipos"}
                ,{2501,"Valor venta debe ser mayor a cero"}
                ,{2502,"Los valores totales deben ser mayores a cero"}
                ,{2503,"PaidAmount: monto anticipado por documento debe ser mayor a cero"}
                ,{2504,"Falta referencia de la factura relacionada con anticipo"}
                ,{2505,"cac:PrepaidPayment/cbc:ID/@SchemaID: Código de referencia debe ser 02 o 03"}
                ,{2506,"cac:PrepaidPayment/cbc:ID: Factura o boleta no existe o comunicada de Baja"}
                ,{2507,"Factura relacionada con anticipo no corresponde como factura de anticipo"}
                ,{2508,"Ingresar documentos por anticipos"}
                ,{2509,"Total de anticipos diferente a los montos anticipados por documento"}
                ,{2510,"Nro nombre del documento no tiene el formato correcto"}
                ,{2511,"El tipo de documento no es aceptado"}
                ,{2512,"No existe información de serie o número"}
                ,{2513,"Dato no cumple con formato de acuerdo al número de comprobante"}
                ,{2514,"No existe información de receptor de documento"}
                ,{2515,"Dato ingresado no cumple con catalogo 6"}
                ,{2516,"Debe indicar tipo de documento"}
                ,{2517,"Dato no cumple con formato establecido"}
                ,{2518,"Calculo IGV no es correcto"}
                ,{2519,"El importe total no coincide con la sumatoria de los valores de venta mas los tributos mas los cargos"}
                ,{2520,"cac:PrepaidPayment/cbc:InstructionID/@SchemaID – El tipo documento debe ser 6 delcatálogode tipo de documento"}
                ,{2521,"cac:PrepaidPayment/cbc:ID - El dato ingresado debe indicar SERIE-CORRELATIVO del documento que serealizóel anticipo"}
                ,{2522,"No existe información del documento del anticipo."}
                ,{2523,"GrossWeightMeasure – El dato ingresado no cumple con el formato establecido"}
                ,{2524,"El dato ingresado en Amount no cumple con el formato establecido"}
                ,{2525,"El dato ingresado en Quantity no cumple con el formato establecido"}
                ,{2526,"El dato ingresado en Percent no cumple con el formato establecido"}
                ,{2527,"PrepaidAmount: Monto total anticipado debe ser mayor a cero"}
                ,{2528,"cac:OriginatorDocumentReference/cbc:ID/@SchemaID – El tipo documento debe ser 6 delcatálogode tipo de documento"}
                ,{2529,"RUC queemitiódocumento de anticipo, no existe"}
                ,{2530,"RUC que solicita laemisiónde la factura, no existe"}
                ,{2531,"Códigodel Local Anexo del emisor no existe"}
                ,{2532,"No existe información de modalidad de transporte"}
                ,{2533,"Si ha consignado Transporte Privado, debe consignar Licencia de conducir, Placa, N constancia deinscripcióny marca delvehículo"}
                ,{2534,"Si ha consignado Transporte púbico, debe consignar Datos del transportista"}
                ,{2535,"La nota de crédito por otros conceptos tributarios debe tener Otros Documentos Relacionados"}
                ,{2536,"Serie ynúmerono se encuentra registrado como baja por cambio de destinatario"}
                ,{2537,"cac:OrderReference/cac:DocumentReference/cbc:DocumentTypeCode - El tipo de documento de serie y número dado de baja es incorrecta"}
                ,{2538,"El contribuyente no se encuentra autorizado como emisorelectrónicode Guía o de factura o deboleta FacturaGEM"}
                ,{2539,"El contribuyente noestáactivo"}
                ,{2540,"El contribuyente noestáhabido"}
                ,{2541,"El XML no contiene el tag o no existeinformacióndel tipo de documento identidad del remitente"}
                ,{2542,"cac:DespatchSupplierParty/cbc:CustomerAssignedAccountID@schemeID - El valor ingresado como tipo de documento identidad del remitente es incorrecta"}
                ,{2543,"El XML no contiene el tag o no existeinformaciónde la dirección completa y detallada en domicilio fiscal"}
                ,{2544,"El XML no contiene el tag o no existe información de la provincia en domicilio fiscal"}
                ,{2545,"El XML no contiene el tag o no existe información del departamento en domicilio fiscal"}
                ,{2546,"El XML no contiene el tag o no existe información del distrito en domicilio fiscal"}
                ,{2547,"El XML no contiene el tag o no existe información del país en domicilio fiscal"}
                ,{2548,"El valor del país inválido"}
                ,{2549,"El XML no contiene el tag o no existeinformacióndel tipo de documento identidad del destinatario"}
                ,{2550,"cac:DeliveryCustomerParty/cbc:CustomerAssignedAccountID@schemeID - El dato ingresado de tipo de documento identidad del destinatario no cumple con elestándar"}
                ,{2551,"El XML no contiene el tag o no existeinformaciónde CustomerAssignedAccountID del proveedor de servicios"}
                ,{2552,"El XML no contiene el tag o no existeinformacióndel tipo de documento identidad del proveedor"}
                ,{2553,"cac:SellerSupplierParty/cbc:CustomerAssignedAccountID@schemeID - El dato ingresado no es valido"}
                ,{2554,"Para el motivo de traslado ingresado el Destinatario debe ser igual al remitente"}
                ,{2555,"Destinatario no debe ser igual al remitente"}
                ,{2556,"cbc:TransportModeCode - dato ingresado no es valido"}
                ,{2557,"La fecha del StartDate no debe ser menor al Today"}
                ,{2558,"El XML no contiene el tag o no existeinformaciónen Numero de Ruc del transportista"}
                ,{2559,"/DespatchAdvice/cac:Shipment/cac:ShipmentStage/cac:CarrierParty/cac:PartyIdentification/cbc:ID - El dato ingresado no cumple con el formato establecido"}
                ,{2560,"Transportista no debe ser igual al remitente o destinatario"}
                ,{2561,"El XML no contiene el tag o no existeinformacióndel tipo de documento identidad del transportista"}
                ,{2562,"/DespatchAdvice/cac:Shipment/cac:ShipmentStage/cac:CarrierParty/cac:PartyIdentification/cbc:ID@schemeID - El dato ingresado no es valido"}
                ,{2563,"El XML no contiene el tag o no existeinformaciónde Apellido, Nombre orazónsocial del transportista"}
                ,{2564,"Razónsocial transportista - El dato ingresado no cumple con el formato establecido"}
                ,{2565,"El XML no contiene el tag o no existeinformacióndel tipo de unidad de transporte"}
                ,{2566,"El XML no contiene el tag o no existeinformacióndelNúmerode placa del vehículo"}
                ,{2567,"Númerode placa del vehículo - El dato ingresado no cumple con el formato establecido"}
                ,{2568,"El XML no contiene el tag o no existeinformaciónen el Numero de documento de identidad del conductor"}
                ,{2569,"Documento identidad del conductor - El dato ingresado no cumple con el formato establecido"}
                ,{2570,"El XML no contiene el tag o no existeinformacióndel tipo de documento identidad del conductor"}
                ,{2571,"cac:DriverPerson/ID@schemeID - El valor ingresado de tipo de documento identidad de conductor es incorrecto"}
                ,{2572,"El XML no contiene el tag o no existeinformacióndel Numero de licencia del conductor"}
                ,{2573,"Numero de licencia del conductor - El dato ingresado no cumple con el formato establecido"}
                ,{2574,"El XML no contiene el tag o no existeinformacióndedireccióndetallada de punto de llegada"}
                ,{2575,"El XML no contiene el tag o no existeinformaciónde CityName"}
                ,{2576,"El XML no contiene el tag o no existeinformaciónde District"}
                ,{2577,"El XML no contiene el tag o no existeinformacióndedireccióndetallada de punto de partida"}
                ,{2578,"El XML no contiene el tag o no existeinformaciónde CityName"}
                ,{2579,"El XML no contiene el tag o no existeinformaciónde District"}
                ,{2580,"El XML No contiene el tag o no existe información de la cantidad delítem"}
                ,{2600,"El comprobante fue enviado fuera del plazo permitido."}
                ,{2601,"Señor contribuyente a la fecha no se encuentra registrado ó habilitado con la condición de Agente de percepción."}
                ,{2602,"El régimen percepción enviado no corresponde con su condición de Agente de percepción."}
                ,{2603,"La tasa de percepción enviada no corresponde con el régimen de percepción."}
                ,{2604,"El Cliente no puede ser el mismo que el Emisor del comprobante de percepción."}
                ,{2605,"Número de RUC del Cliente no existe."}
                ,{2606,"Documento de identidad del Cliente no existe."}
                ,{2607,"La moneda del importe de cobro debe ser la misma que la del documento relacionado."}
                ,{2608,"Los montos de pago, percibidos y montos cobrados consignados para el documento relacionado no son correctos."}
                ,{2609,"El comprobante electrónico enviado no se encuentra registrado en la SUNAT."}
                ,{2610,"La fecha de emisión, Importe total del comprobante y la moneda del comprobante electrónico enviado no son los registrados en los Sistemas de SUNAT."}
                ,{2611,"El comprobante electrónico no ha sido emitido al cliente."}
                ,{2612,"La fecha de cobro debe estar entre el primer día calendario del mes al cual corresponde la fecha de emisión del comprobante de percepción o desde la fecha de emisión del comprobante relacionado."}
                ,{2613,"El Nro. de documento con número de cobro ya se encuentra en la Relación de Documentos Relacionados agregados."}
                ,{2614,"El Nro. de documento con el número de cobro ya se encuentra registrado como pago realizado."}
                ,{2615,"Importe total percibido debe ser igual a la suma de los importes percibidos por cada documento relacionado."}
                ,{2616,"Importe total cobrado debe ser igual a la suma de los importe totales cobrados por cada documento relacionado."}
                ,{2617,"Señor contribuyente a la fecha no se encuentra registrado ó habilitado con la condición de Agente de retención."}
                ,{2618,"El régimen retención enviado no corresponde con su condición de Agente de retención."}
                ,{2619,"La tasa de retención enviada no corresponde con el régimen de retención."}
                ,{2620,"El Proveedor no puede ser el mismo que el Emisor del comprobante de retención."}
                ,{2621,"Número de RUC del Proveedor no existe."}
                ,{2622,"La moneda del importe de pago debe ser la misma que la del documento relacionado."}
                ,{2623,"Los montos de pago, retenidos y montos pagados consignados para el documento relacionado no son correctos."}
                ,{2624,"El comprobante electrónico no ha sido emitido por el proveedor."}
                ,{2625,"La fecha de pago debe estar entre el primer día calendario del mes al cual corresponde la fecha de emisión del comprobante de retención o desde la fecha de emisión del comprobante relacionado."}
                ,{2626,"El Nro. de documento con el número de pago ya se encuentra en la Relación de Documentos Relacionados agregados."}
                ,{2627,"El Nro. de documento con el número de pago ya se encuentra registrado como pago realizado."}
                ,{2628,"Importe total retenido debe ser igual a la suma de los importes retenidos por cada documento relacionado."}
                ,{2629,"Importe total pagado debe ser igual a la suma de los importes pagados por cada documento relacionado."}
                ,{2630,"La serie onúmerodel documento(01) modificado por la Nota deCréditono cumple con el formato establecido para tipocódigoNotaCrédito10."}
                ,{2631,"La serie onúmerodel documento(12) modificado por la Nota deCréditono cumple con el formato establecido para tipocódigoNotaCrédito10."}
                ,{2632,"La serie onúmerodel documento(56) modificado por la Nota deCréditono cumple con el formato establecido para tipocódigoNotaCrédito10."}
                ,{2633,"La serie onúmerodel documento(03) modificado por la Nota deCréditono cumple con el formato establecido para tipocódigoNotaCrédito10."}
                ,{2634,"ReferenceID - El dato ingresado debe indicar serie correcta del documento al que se relaciona la Nota tipo 10."}
                ,{2635,"Debe existir DocumentTypeCode de Otros documentos relacionados con valor 99 para un tipocódigoNotaCrédito10."}
                ,{2636,"No existe datos del ID de los documentos relacionados con valor 99 para un tipocódigoNotaCrédito10."}
                ,{2637,"No existe datos del DocumentType de los documentos relacionados con valor 99 para un tipocódigoNotaCrédito10."}
                ,{2640,"Operacióngratuita, solo debe consignar un monto referencial"}
                ,{2641,"Operacióngratuita, debe consignar Total valor venta - operaciones gratuitas mayor a cero"}
                ,{2642,"Operaciones deexportación, deben consignar TipoAfectaciónigual a 40"}
                ,{2643,"Factura deoperaciónsujeta IVAP debe consignar Monto de impuestos porítem"}
                ,{2644,"Factura deoperaciónsujeta IVAP solo debe tener ítems con código afectación IGV 17."}
                ,{2645,"Factura deoperaciónsujeta a IVAP debe consignarítemsconcódigode tributo 1000"}
                ,{2646,"Factura deoperaciónsujeta a IVAP debe consignarítemscon nombre de tributo IVAP"}
                ,{2647,"Código tributo UN/ECE debe ser VAT"}
                ,{2648,"Factura deoperaciónsujeta al IVAP, solo puede consignarinformaciónparaoperacióngravadas"}
                ,{2649,"Operación sujeta al IVAP, debe consignar monto en total operaciones gravadas"}
                ,{2650,"Factura deoperaciónsujeta al IVAP , no debe consignar valor para ISC o debe ser 0"}
                ,{2651,"Factura deoperaciónsujeta al IVAP , no debe consignar valor para IGV o debe ser 0"}
                ,{2652,"Factura deoperaciónsujeta al IVAP , debe registrar mensaje 2007"}
                ,{2653,"Servicios prestados No domiciliados. Total IGV debesermayor a cero"}
                ,{2654,"Servicios prestados No domiciliados. Código tributo a consignar debe ser 1000"}
                ,{2655,"Servicios prestados No domiciliados. El código de afectación debe ser 40"}
                ,{2656,"Servicios prestados No domiciliados. Código tributo UN/ECE debe ser VAT"}
                ,{2657,"El Nro. de documento <serie>-<número> yafueutilizado en laemisiónde CPE."}
                ,{2658,"El Nro. de documento <serie>-<número> no se hainformadoo no se encuentra en estado Revertido"}
                ,{2659,"La fecha de cobro de cada documento relacionado deben ser del mismo Periodo (mm/aaaa), asimismo estas fechas podrán ser menores o iguales a la fecha de emisión del comprobante de percepción"}
                ,{2660,"Los datos del CPE revertido no corresponden a los registrados en la SUNAT"}
                ,{2661,"La fecha de cobro de cada documento relacionado deben ser del mismo Periodo (mm/aaaa), asimismo estas fechas podrán ser menores o iguales a la fecha de emisión del comprobante deretención"}
                ,{2662,"El Nro. de documento <serie>-<número> yafueutilizado en laemisiónde CRE."}
                ,{2663,"El documento indicado no existe no puede ser modificado/eliminado"}
                ,{2664,"Elcálculode la base imponible de percepción y el monto de la percepción no coincide con el monto total informado."}
                ,{2665,"El contribuyente no se encuentra autorizado a emitir Tickets"}
                ,{2666,"Las percepciones son solo válidas para boletas de venta al contado."}
                ,{2667,"Importe total percibido debe ser igual a la suma de los importes percibidos por cada documento relacionado."}
                ,{2668,"Importe total cobrado debe ser igual a la suma de los importes cobrados por cada documento relacionado."}
                ,{2669,"El dato ingresado en TotalInvoiceAmount debe sernuméricomayor a cero"}
                ,{2670,"La razón social no corresponde al ruc informado."}
                ,{2671,"La fecha de generación de la comunicación debe ser mayor o igual a la fecha de generación del documento revertido."}
                ,{2672,"La fecha de generación del documento revertido debe ser menor o igual a la fecha actual."}
                ,{2673,"El dato ingresado no cumple con el formato RR-fecha-correlativo."}
                ,{2674,"El dato ingresado no cumple con el formato de DocumentSerialID, para DocumentTypeCode con valor 20."}
                ,{2675,"El dato ingresado no cumple con el formato de DocumentSerialID, para DocumentTypeCode con valor 40."}
                ,{2676,"El XML no contiene el tag o no existe información del número de RUC del emisor"}
                ,{2677,"El valor ingresado como número de RUC del emisor es incorrecto"}
                ,{2678,"El XML no contiene el atributo o no existe información del tipo de documento del emisor"}
                ,{2679,"El XML no contiene el tag o no existe información del número de documento de identidad del cliente"}
                ,{2680,"El valor ingresado como documento de identidad del cliente es incorrecto"}
                ,{2681,"El XML no contiene el atributo o no existe información del tipo de documento del cliente"}
                ,{2682,"El valor ingresado como tipo de documento del cliente es incorrecto"}
                ,{2683,"El XML no contiene el tag o no existe información del Importe total Percibido"}
                ,{2684,"El XML no contiene el tag o no existe información de la moneda del Importe total Percibido"}
                ,{2685,"El valor de la moneda del Importe total Percibido debe ser PEN"}
                ,{2686,"El XML no contiene el tag o no existe información del Importe total Cobrado"}
                ,{2687,"El dato ingresado en SUNATTotalCashed debe ser numérico mayor a cero"}
                ,{2689,"El XML no contiene el tag o no existe información de la moneda del Importe total Cobrado"}
                ,{2690,"El valor de la moneda del Importe total Cobrado debe ser PEN"}
                ,{2691,"El XML no contiene el tag o no existe información del tipo de documento relacionado"}
                ,{2692,"El tipo de documento relacionado no es válido"}
                ,{2693,"El XML no contiene el tag o no existe información del número de documento relacionado"}
                ,{2694,"Elnúmero de documento relacionado no está permitido o no es valido"}
                ,{2695,"El XML no contiene el tag o no existe información del Importe total documento Relacionado"}
                ,{2696,"El dato ingresado en el importe total documento relacionado debe ser numérico mayor a cero"}
                ,{2697,"El XML no contiene el tag o no existe información del número de cobro"}
                ,{2698,"El dato ingresado en el número de cobro no es válido"}
                ,{2699,"El XML no contiene el tag o no existe información del Importe del cobro"}
                ,{2700,"El dato ingresado en el Importe del cobro debe ser numérico mayor a cero"}
                ,{2701,"El XML no contiene el tag o no existe información de la moneda del documento Relacionado"}
                ,{2702,"El XML no contiene el tag o no existe información de la fecha de cobro del documento Relacionado"}
                ,{2703,"La fecha de cobro del documento relacionado no es válido"}
                ,{2704,"El XML no contiene el tag o no existe informacióndel Importe percibido"}
                ,{2705,"El dato ingresado en el Importe percibido debe ser numérico mayor a cero"}
                ,{2706,"El XML no contiene el tag o no existe información de la moneda de importe percibido"}
                ,{2707,"El valor de la moneda de importe percibido debe ser PEN"}
                ,{2708,"El XML no contiene el tag o no existe información de la Fecha dePercepción"}
                ,{2709,"La fecha depercepciónno es válido"}
                ,{2710,"El XML no contiene el tag o no existe información del Monto total a cobrar"}
                ,{2711,"El dato ingresado en el Monto total a cobrar debe ser numérico mayor a cero"}
                ,{2712,"El XML no contiene el tag o no existe información de la moneda del Monto total a cobrar"}
                ,{2713,"El valor de la moneda del Monto total a cobrar debe ser PEN"}
                ,{2714,"El valor de la moneda de referencia para el tipo de cambio no es válido"}
                ,{2715,"El valor de la moneda objetivo para la Tasa de Cambio debe ser PEN"}
                ,{2716,"El dato ingresado en el tipo de cambio debe ser numérico mayor a cero"}
                ,{2717,"La fecha de cambio no es válido"}
                ,{2718,"El valor de la moneda del documento Relacionado no es válido"}
                ,{2719,"El XML no contiene el tag o no existe información de la moneda de referencia parael tipo de cambio"}
                ,{2720,"El XML no contiene el tag o no existe información de la moneda objetivo para la Tasa de Cambio"}
                ,{2721,"El XML no contiene el tag o no existe información del tipo de cambio"}
                ,{2722,"El XML no contiene el tag o no existe información de la fecha de cambio"}
                ,{2723,"El XML no contiene el tag o no existe información del número de documento de identidad del proveedor"}
                ,{2724,"El valor ingresado como documento de identidad del proveedor es incorrecto"}
                ,{2725,"El XML no contiene el tag o no existe información del Importe total Retenido"}
                ,{2726,"El XML no contiene el tag o no existe información de la moneda del Importe total Retenido"}
                ,{2727,"El XML no contiene el tag o no existe información de la moneda del Importe total Retenido"}
                ,{2728,"El valor de la moneda del Importe total Retenido debe ser PEN"}
                ,{2729,"El XML no contiene el tag o no existe información del Importe total Pagado"}
                ,{2730,"El dato ingresado en SUNATTotalPaid debe ser numérico mayor a cero"}
                ,{2731,"El XML no contiene el tag o no existe información de la moneda del Importe total Pagado"}
                ,{2732,"El valor de la moneda del Importe total Pagado debe ser PEN"}
                ,{2733,"El XML no contiene el tag o no existe información del número de pago"}
                ,{2734,"El dato ingresado en el número de pago no es válido"}
                ,{2735,"El XML no contiene el tag o no existe información del Importe del pago"}
                ,{2736,"El dato ingresado en el Importe del pago debe ser numérico mayor a cero"}
                ,{2737,"El XML no contiene el tag o no existe información de la fecha de pago del documento Relacionado"}
                ,{2738,"La fecha de pago del documento relacionado no es válido"}
                ,{2739,"El XML no contiene el tag o no existe información del Importe retenido"}
                ,{2740,"El dato ingresado en el Importe retenido debe ser numérico mayor a cero"}
                ,{2741,"El XML no contiene el tag o no existe información de la moneda de importe retenido"}
                ,{2742,"El valor de la moneda de importe retenido debe ser PEN"}
                ,{2743,"El XML no contiene el tag o no existe información de la Fecha de Retención"}
                ,{2744,"La fecha de retención no es válido"}
                ,{2745,"El XML no contiene el tag o no existe información del Importe total a pagar (neto)"}
                ,{2746,"El dato ingresado en el Importe total a pagar (neto) debe ser numérico mayor a cero"}
                ,{2747,"El XML no contiene el tag o no existe información de la Moneda del monto neto pagado"}
                ,{2748,"El valor de la Moneda del monto neto pagado debe ser PEN"}
                ,{2749,"La moneda de referencia para el tipo de cambio debe ser la misma que la del documento relacionado"}
                ,{2750,"El comprobante que se informa debe existir y estar en estado emitido"}
                ,{2751,"El comprobante que se informa ya se encuentra en estado revertido"}
                ,{2752,"Elnúmerode ítem no puede estar duplicado"}
                ,{4000,"El documento ya fue presentado anteriormente."}
                ,{4001,"Elnúmerode RUC del receptor no existe."}
                ,{4002,"Para el TaxTypeCode,estáusando un valor que no existe en elcatálogo."}
                ,{4003,"El comprobante fue registrado previamente como rechazado."}
                ,{4004,"El DocumentTypeCode de lasguíasdebe existir y tener 2 posiciones"}
                ,{4005,"El DocumentTypeCode de lasguíasdebe ser 09 o 31"}
                ,{4006,"El ID de lasguíasdebe tenerinformaciónde la SERIE-NUMERO deguía."}
                ,{4007,"El XML no contiene el ID de lasguías."}
                ,{4008,"El DocumentTypeCode de Otros documentos relacionados no cumple con elestándar."}
                ,{4009,"El DocumentTypeCode de Otros documentos relacionados tiene valores incorrectos."}
                ,{4010,"El ID de los documentos relacionados no cumplen con elestándar."}
                ,{4011,"El XML no contiene el tag ID de documentos relacionados."}
                ,{4012,"El ubigeo indicado en el comprobante no es el mismo queestáregistrado para el contribuyente."}
                ,{4013,"El RUC del receptor noestáactivo"}
                ,{4014,"El RUC del receptor noestáhabido"}
                ,{4015,"Si el tipo de documento del receptor no es RUC, debe tener operaciones deexportación"}
                ,{4016,"El total valor venta neta de oper. gravadas IGV debe ser mayor a 0.00 o debe existir oper. gravadas onerosas"}
                ,{4017,"El total valor venta neta de oper. inafectas IGV debe ser mayor a 0.00 o debe existir oper. inafectas onerosas o de export."}
                ,{4018,"El total valor venta neta de oper. exoneradas IGV debe ser mayor a 0.00 o debe existir oper. exoneradas"}
                ,{4019,"Elcálculodel IGV no es correcto"}
                ,{4020,"El ISC noestáinformado correctamente"}
                ,{4021,"Si se utiliza la leyenda concódigo2000, el importe depercepcióndebe ser mayor a 0.00"}
                ,{4022,"Si se utiliza la leyenda con código 2001, el total de operaciones exoneradas debe ser mayor a 0.00"}
                ,{4023,"Si se utiliza la leyenda con código 2002, el total de operaciones exoneradas debe ser mayor a 0.00"}
                ,{4024,"Si se utiliza la leyenda con código 2003, el total de operaciones exoneradas debe ser mayor a 0.00"}
                ,{4025,"Si usa la leyenda de Transferencia oServiciogratuito, todos losítemsdeben ser no onerosos"}
                ,{4026,"No se puede indicar Guia deremisiónde remitente y Guia deremisiónde transportista en el mismo documento"}
                ,{4027,"El importe total no coincide con la sumatoria de los valores de venta mas los tributos mas los cargos"}
                ,{4028,"El monto total de la nota decréditodebe ser menor o igual al monto de la factura"}
                ,{4029,"El ubigeo indicado en el comprobante no es el mismo queestáregistrado para el contribuyente"}
                ,{4030,"El ubigeo indicado en el comprobante no es el mismo queestáregistrado para el contribuyente"}
                ,{4031,"Debe indicar el nombre comercial"}
                ,{4032,"Si el código del motivo de emisión de la Nota deCréditoes 03, debe existir la descripción delítem"}
                ,{4033,"La fecha de generación de la numeración debe ser menor o igual a la fecha de generación de la comunicación"}
                ,{4034,"El comprobante fue registrado previamente como baja"}
                ,{4035,"El comprobante fue registrado previamente como rechazado"}
                ,{4036,"La fecha de emisión de los rangos debe ser menor o igual a la fecha de generación del resumen"}
                ,{4037,"Elcálculodel Total de IGV delÍtemno es correcto"}
                ,{4038,"El resumen contiene menos series por tipo de documento que el envío anterior para la misma fecha de emisión"}
                ,{4039,"No ha consignado información del ubigeo del domicilio fiscal"}
                ,{4040,"Si el importe depercepciónes mayor a 0.00, debe utilizar una leyenda concódigo2000"}
                ,{4041,"Elcódigodepaísdebe ser PE"}
                ,{4042,"Para sac:SUNATTransaction/cbc:ID, se está usando un valor que no existe en el catálogo. Nro. 17"}
                ,{4043,"Para el TransportModeCode, se está usando un valor que no existe en el catálogo Nro. 18"}
                ,{4044,"PrepaidAmount: Monto total anticipado no coincide con la sumatoria de los montos por documento de anticipo"}
                ,{4045,"No debe consignar los datos del transportista para la modalidad de transporte 02 – Transporte Privado"}
                ,{4046,"No debe consignar información adicional en la dirección para los locales anexos"}
                ,{4047,"sac:SUNATTransaction/cbc:ID debe ser igual a 06 cuando ingrese información para sustentar el traslado"}
                ,{4048,"cac:AdditionalDocumentReference/cbc:DocumentTypeCode - Contiene un valor no valido para documentos relacionado"}
                ,{4049,"Elnúmerode DNI del receptor no existe"}
                ,{4050,"Elnúmerode RUC del proveedor no existe"}
                ,{4051,"El RUC del proveedor noestáactivo"}
                ,{4052,"El RUC del proveedor noestáhabido"}
                ,{4053,"Proveedor no debe ser igual al remitente o destinatario"}
                ,{4054,"La guía no debe contener datos del proveedor"}
                ,{4055,"El XML no contieneinformaciónen el tag cbc:Information"}
                ,{4056,"El XML no contiene el tag o no existe información en el tag SplitConsignmentIndicator"}
                ,{4057,"GrossWeightMeasure – El dato ingresado no cumple con el formato establecido"}
                ,{4058,"cbc:TotalPackageQuantity - El dato ingresado no cumple con el formato establecido"}
                ,{4059,"Numero de bultos o pallets - información válida para importación"}
                ,{4060,"La guía no debe contener datos del transportista"}
                ,{4061,"Elnúmerode RUC del transportista no existe"}
                ,{4062,"El RUC del transportista noestáactivo"}
                ,{4063,"El RUC del transportista noestáhabido"}
                ,{4064,"/DespatchAdvice/cac:Shipment/cac:ShipmentStage/cac:TransportMeans/cbc:RegistrationNationalityID - El dato ingresado no cumple con el formato establecido"}
                ,{4065,"cac:TransportMeans/cbc:TransportMeansTypeCode - El valor ingresado como tipo de unidad de transporte es incorrecta"}
                ,{4066,"Elnúmerode DNI del conductor no existe"}
                ,{4067,"El XML no contiene el tag o no existeinformacióndel ubigeo del punto de llegada"}
                ,{4068,"Direcciónde punto dellegada- El dato ingresado no cumple con el formato establecido"}
                ,{4069,"CityName - El dato ingresado no cumple con el formato establecido"}
                ,{4070,"District - El dato ingresado no cumple con el formato establecido"}
                ,{4071,"Numero de Contenedor - El dato ingresado no cumple con el formato establecido"}
                ,{4072,"Numero de contenedor - información válida para importación"}
                ,{4073,"TransEquipmentTypeCode - El valor ingresado como tipo de contenedor es incorrecta"}
                ,{4074,"Numero Precinto - El dato ingresado no cumple con el formato establecido"}
                ,{4075,"El XML no contiene el tag o no existeinformacióndel ubigeo del punto de partida"}
                ,{4076,"Direcciónde punto de partida - El dato ingresado no cumple con el formato establecido"}
                ,{4077,"CityName - El dato ingresado no cumple con el formato establecido"}
                ,{4078,"District - El dato ingresado no cumple con el formato establecido"}
                ,{4079,"Código de Puerto o Aeropuerto - El dato ingresado no cumple con el formato establecido"}
                ,{4080,"Tipo de Puerto o Aeropuerto - El dato ingresado no cumple con el formato establecido"}
                ,{4081,"El XML No contiene El tag o No existe información del Numero de orden delítem"}
                ,{4082,"Número de Orden del Ítem - El orden del ítem no cumple con el formato establecido"}
                ,{4083,"Cantidad - El dato ingresado no cumple con el formato establecido"}
                ,{4084,"Descripción del Ítem - El dato ingresado no cumple con el formato establecido"}
                ,{4085,"Código del Ítem - El dato ingresado no cumple con el formato establecido"}
                ,{4086,"El emisor y el cliente son Agentes de percepción de combustible en la fecha de emisión."}
                ,{4087,"El Comprobante de Pago Electrónico no está Registrado en los Sistemas de la SUNAT."}
                ,{4088,"El Comprobante de Pago no está autorizado en los Sistemas de la SUNAT."}
                ,{4089,"La operación con este cliente está excluida del sistema de percepción. Es agente de retención."}
                ,{4090,"La operación con este cliente está excluida del sistema de percepción. Es entidad exceptuada de la percepción."}
                ,{4091,"La operación con este proveedor está excluida del sistema de retención. Es agente de percepción, agente de retención o buen contribuyente."}
                ,{4092,"El nombre comercial del emisor no cumple con el formato establecido"}
                ,{4093,"El ubigeo del emisor no cumple con el formato establecido o no es válido"}
                ,{4094,"La dirección completa y detallada del domicilio fiscal del emisor no cumple con el formato establecido"}
                ,{4095,"La urbanización del domicilio fiscal del emisor no cumple con el formato establecido"}
                ,{4096,"La provincia del domicilio fiscal del emisor no cumple con el formato establecido"}
                ,{4097,"El departamento del domicilio fiscal del emisor no cumple con el formato establecido"}
                ,{4098,"El distrito del domicilio fiscal del emisor no cumple con el formato establecido"}
                ,{4099,"El nombre comercial del cliente no cumple con el formato establecido"}
                ,{4100,"El ubigeo del cliente no cumple con el formato establecido o no es válido"}
                ,{4101,"La dirección completa y detallada del domicilio fiscal del cliente no cumple con el formato establecido"}
                ,{4102,"La urbanización del domicilio fiscal del cliente no cumple con el formato establecido"}
                ,{4103,"La provincia del domicilio fiscal del cliente no cumple con el formato establecido"}
                ,{4104,"El departamento del domicilio fiscal del cliente no cumple con el formato establecido"}
                ,{4105,"El distrito del domicilio fiscal del cliente no cumple con el formato establecido"}
                ,{4106,"El nombre comercial del proveedor no cumple con el formato establecido"}
                ,{4107,"El ubigeo del proveedor no cumple con el formato establecido o no es válido"}
                ,{4108,"La dirección completa y detallada del domicilio fiscal del proveedor no cumple con el formato establecido"}
                ,{4109,"La urbanización del domicilio fiscal del proveedor no cumple con el formato establecido"}
                ,{4110,"La provincia del domicilio fiscal del proveedor no cumple con el formato establecido"}
                ,{4111,"El departamento del domicilio fiscal del proveedor no cumple con el formato establecido"}
                ,{4112,"El distrito del domicilio fiscal del proveedor no cumple con el formato establecido"}
            };

        public enum BillingSentStatus
        {
            Success = 1,
            Error = 2
        }

        public const string DocumentTypeBoleta = "03";

        public const string DocumentTypeFactura = "01";

    }
}
