﻿function StageDescrbtion(t, e) { $(`#${e}StDes`).val(t), $(`#${e}2`).modal("show") } function RecheckRequest(t, e) { $(`#${t}3`).modal("show"), $(`#${t}3`).attr("url", e) } function RecheckAccept(t) { const e = $(`#${t}3`).attr("url"), n = new FormData; n.append("studentId", t), n.append("studentdescribtion", $(`#${t}Des`).val()), $.ajax({ type: "POST", url: `../${e}`, contentType: !1, processData: !1, data: n, success: function (t) { 1 == t ? swal.fire("موفق!", t.message, "success").then(function (t) { window.location.reload() }) : "nullstates" == t && swal.fire("خطا", "چنین دانشجویی در سیستم ثبت نشده است", "error") }, error: function (t, e, n) { alert(t.status), alert(n) } }) } function GetHistory(t) { $(`#${t}`).modal("show") } $(document).ready(function () { $("#btnShowHistory").on("click", function () { $(this).closest("div .page-active").css("display", "none"), $(this).closest("div .page-active").attr("class", "page-cloned"), $("#btnHideHistory").closest("div .page-cloned").css("display", ""), $("#btnHideHistory").closest("div .page-cloned").attr("class", "page-active") }), $("#btnHideHistory").on("click", function () { $(this).closest("div .page-active").css("display", "none"), $(this).closest("div .page-active").attr("class", "page-cloned"), $("#btnShowHistory").closest("div .page-cloned").css("display", ""), $("#btnShowHistory").closest("div .page-cloned").attr("class", "page-active") }), $("#btnsubmit").on("click", function () { if (!1 === $("#checkAgreement").prop("checked")) return void swal.fire("هشدار!", ' قوانین را مطالعه کرده و سپس " می پذیرم "را ثبت کنید', "error"); const t = new FormData; t.append("describtion", $("#Describtion").val()), $.ajax({ type: "POST", url: "Home/SendToEduExpert", contentType: !1, processData: !1, data: t, success: function (t) { if (1 == t) swal.fire("موفق!", t.message, "success").then(function (t) { window.location.href = "/" }); else if ("DuplicateRequest" == t) swal.fire("هشدار", "شما هم اکنون یک درخواست فعال دارید. لطفا تا نتیجه آن منتظر بمانید", "warning"); else if ("RecheckAllWarning" == t) { const e = new FormData; swal.fire({ title: "هشدار", text: "شما قبلا درخواستی ثبت کرده اید که بخشی از مراحل را طی کرده است،با این کار درخواست شما دوباره وارد چرخه ابتدایی می شود، اگر مدارک مراحل قبلی شما تکمیل است، از بخش درخواست فعال می توانید از آخرین مرحله درخواست خود را ثبت کنید", icon: "warning", showCancelButton: !0, confirmButtonColor: "#30d699", cancelButtonColor: "#f92b64", confirmButtonText: "ادامه می دهم", cancelButtonText: "بازگشت" }).then(n => { n.value && (e.append("isAgreed", !0), e.append("describtion", $("#Describtion").val()), $.ajax({ type: "POST", url: "Home/SendToEduExpert", contentType: !1, processData: !1, data: e, success: function (e) { swal.fire("موفق!", t.message, "success").then(function (t) { location.reload() }) } })) }) } else "nullstates" == t && swal.fire("خطا", "مشکلی پیش آمد لطفا دوباره امتحان کنید در غیر اینصورت با پشتیبانی تماس بگیرید", "error") }, error: function (t, e, n) { alert(t.status), alert(n) } }) }), $("#StudentLogin").on("click", function () { const t = new FormData; t.append("StudentId", $("#StudentIdInput").val()), t.append("NationalNo", $("#StudentNoInput").val()), $.ajax({ type: "POST", url: "Register", contentType: !1, processData: !1, data: t, success: function (t) { 1 == t ? swal.fire("موفق", " ورود شما با موفقیت انجام شد", "success").then(function () { window.location.href = "/" }) : 0 == t && swal.fire("اخطار", " اطلاعات وارد شده صحیح نیست", "error") }, error: function (t, e, n) { alert(t.status), alert(n) } }) }), $("#StudentIdInput").on("keyup", function () { const t = new FormData; t.append("id", $(this).val()), $.ajax({ type: "POST", url: "/Account/CheckIdInput", contentType: !1, processData: !1, data: t, success: function (t) { 1 == t ? ($("#StudentIdCheck").html(""), $("#StudentIdInput").attr("class", "form-control input-success")) : 0 == t && ($("#StudentIdCheck").html("شماره دانشجویی معتبر نیست"), $("#StudentIdInput").attr("class", "form-control input-danger")) }, error: function (t, e, n) { alert(t.status), alert(n) } }) }), $("#StudentNoInput").on("keyup", function () { const t = new FormData; t.append("nationalNo", $(this).val()), $.ajax({ type: "POST", url: "CheckNationalNoInput", contentType: !1, processData: !1, data: t, success: function (t) { 1 == t ? ($("#StudentNationalNoCheck").html(""), $("#StudentNoInput").attr("class", "form-control input-success")) : 0 == t && ($("#StudentNationalNoCheck").html("کد ملی معتبر نیست"), $("#StudentNoInput").attr("class", "form-control input-danger")) }, error: function (t, e, n) { alert(t.status), alert(n) } }) }), $("#ResponsibleLogin").on("click", function () { const t = new FormData; t.append("ResponsibleId", $("#ResponsibleIdInput").val()), t.append("NationalNo", $("#ResponsibleNoInput").val()), $.ajax({ type: "POST", url: "ResponsiblesRegister", contentType: !1, processData: !1, data: t, success: function (t) { 1 == t ? swal.fire("موفق", " ورود شما با موفقیت انجام شد", "success").then(function () { window.location.href = "/" }) : 0 == t && swal.fire("اخطار", " اطلاعات وارد شده صحیح نیست", "error") }, error: function (t, e, n) { alert(t.status), alert(n) } }) }), $("#ResponsibleIdInput").on("keyup", function () { const t = new FormData; t.append("id", $(this).val()), $.ajax({ type: "POST", url: "/Account/CheckIdInput", contentType: !1, processData: !1, data: t, success: function (t) { 1 == t ? ($("#ResponsibleIdCheck").html(""), $("#ResponsibleIdInput").attr("class", "form-control input-success")) : 0 == t && ($("#ResponsibleIdCheck").html("شماره شناسایی معتبر نیست"), $("#ResponsibleIdInput").attr("class", "form-control input-danger")) }, error: function (t, e, n) { alert(t.status), alert(n) } }) }), $("#ResponsibleNoInput").on("keyup", function () { const t = new FormData; t.append("nationalNo", $(this).val()), $.ajax({ type: "POST", url: "CheckNationalNoInput", contentType: !1, processData: !1, data: t, success: function (t) { 1 == t ? ($("#ResponsibleNationalNoCheck").html(""), $("#ResponsibleNoInput").attr("class", "form-control input-success")) : 0 == t && ($("#ResponsibleNationalNoCheck").html("کد ملی معتبر نیست"), $("#ResponsibleNoInput").attr("class", "form-control input-danger")) }, error: function (t, e, n) { alert(t.status), alert(n) } }) }) });