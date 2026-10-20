using ViewModel;
using Larpchive_Of_Our_Own;
TagsDB tags = new TagsDB();
TagList Tlist = tags.SelectAll();
AgeRatingDB agerating = new AgeRatingDB();
AgeRatingList AList = agerating.SelectAll();
PrivacyDB privacy = new PrivacyDB();
PrivacyList PList = privacy.SelectAll();
ChaptersDB chapters = new ChaptersDB();
ChapterList CList = chapters.SelectAll();
UsersDB Users = new UsersDB();
UserList UList = Users.SelectAll();
CommentsDB Comments = new CommentsDB();
CommentList CommentList = Comments.SelectAll();
LanguagesDB Languages = new LanguagesDB();
LanguageList LList = Languages.SelectAll();
//#region
//WorksDB wdb = new();
//WorksList wList = wdb.SelectAll();
//foreach (Works w in wList)
//    Console.WriteLine($"{w.Id}: {w.WorkName}, {w.Description}, {w.ChapterGoal}, {w.Langauge}, {w.Author}, {w.DateOfRealease}, {w.Privacy}, {w.AgeRating}");
//#endregion
//#region
//Tags_On_WorksDB towdb = new();
//Tags_On_WorksList towList = towdb.SelectAll();
//foreach (Tags_On_Works w in towList)
//{
//#endregion
//#region
//AdminDB wdb = new();
//AdminList wList = wdb.SelectAll();
//foreach (Admin a in wList)
//    Console.WriteLine($"{a.Id}, {a.Email}, {a.Username}, {a.DateOfCreation}, {a.IsVerified}");
//#endregion
//    Console.WriteLine($"{w.Id}: {w.WorkId.WorkName}, {w.WorkTags.Tagname}");
//}
//#endregion
//foreach (Tags t in Tlist)
//{
//    Console.WriteLine($"{t.Id}:{t.Tagname}");
//}
//foreach (AgeRating a in AList)
//{
//    Console.WriteLine($"{a.Id}:{a.Age_Rating}");
//}
//foreach (Privacy p in PList)
//{
//    Console.WriteLine($"{p.Id}:{p.PrivacyLevel}");
//}
//foreach (Chapters c in CList)
//{
//    Console.WriteLine($"{c.WorkID}: {c.ChapterNum}, {c.ChapterName}, {c.Summary}, {c.Notes}, {c.Story}");
//}
//foreach (Users u in UList)
//{
//    Console.WriteLine($"{u.Id}, {u.Email}, {u.Username}, {u.DateOfCreation}, {u.IsVerified}");
//}
//foreach (var c in CommentList)
//{
//    Console.WriteLine($"{c.WorkId}: {c.UserId}, {c.DateOfComment}, {c.Rating}, {c.Comment}");
//}
//foreach (var l in LList)
//{
//    Console.WriteLine($"{l.Id}: {l.LanguageNameInEnglish}, {l.LanguageNameInOriginalLangauge}, {l.LettersInAlpabetticalOrder}");
//}
//TagsDB tdb = new();
//TagList tList = tdb.SelectAll();
//foreach (var t in tList)
//{
//    Console.WriteLine(t.Tagname);
//}
//Tags toupdate = tList[0];
//tagstoupdate.Tagname = "Fluff";
//tdb.Update(toupdate);
//int x = tdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//foreach (var t in tList)
//{
//    Console.WriteLine(t.Tagname);
//}
//PrivacyDB pdb = new();
//PrivacyList pList = pdb.SelectAll();
//foreach (var p in pList)
//{
//    Console.WriteLine(p.PrivacyLevel);
//}
//Privacy toupdate = pList[0];
//tagstoupdate.PrivacyLevel = "Everyone";
//pdb.Update(toupdate);
//int x = pdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//foreach (var p in pList)
//{
//    Console.WriteLine(p.PrivacyLevel);
//}
//LanguagesDB ldb = new();
//LanguageList lList = ldb.SelectAll();
//foreach (var l in lList)
//{
//    Console.WriteLine(l.LanguageNameInOriginalLangauge);
//}
//Languages toupdate = lList[0];
//tagstoupdate.LanguageNameInOriginalLangauge = "Slavic";
//ldb.Update(toupdate);
//int x = ldb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//foreach (var l in lList)
//{
//    Console.WriteLine(l.LanguageNameInOriginalLangauge);
//}
//UsersDB udb = new();
//UserList uList = udb.SelectAll();
//foreach (var u in uList)
//{
//    Console.WriteLine(u.Username);
//}
//Users toupdate = uList[0];
//toupdate.Username = "Sheldov";
//udb.Update(toupdate);
//int x = udb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//foreach (var u in uList)
//{
//    Console.WriteLine(u.Username);
//}
//AgeRatingDB adb = new();
//AgeRatingList aList = adb.SelectAll();
//foreach (var a in aList)
//{
//    Console.WriteLine(a.Age_Rating);
//}
//AgeRating toupdate = aList[0];
//toupdate.Age_Rating = "Not Rated";
//adb.Update(toupdate);
//int x = adb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//foreach (var p in aList)
//{
//    Console.WriteLine(p.Age_Rating);
//}
//ChaptersDB cdb = new();
//ChapterList cList = cdb.SelectAll();
//foreach (var c in cList)
//{
//    Console.WriteLine(c.ChapterName);
//}
//Chapters toupdate = cList[0];
//toupdate.ChapterName = "The Burnt Breakfast";
//cdb.Update(toupdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//foreach (var c in cList)
//{
//    Console.WriteLine(c.ChapterName);
//}
//CommentsDB cdb = new();
//CommentList cList = cdb.SelectAll();
//foreach (var c in cList)
//{
//    Console.WriteLine(c.WorkId);
//}
//Comments toupdate = cList[0];
//toupdate.WorkId -= 2;
//cdb.Update(toupdate);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//foreach (var c in cList)
//{
//    Console.WriteLine(c.WorkId);
//}

//WorksDB wdb = new();
//WorksList wList = wdb.SelectAll();
//foreach (var w in wList)
//{
//    Console.WriteLine(w.WorkName);
//}
//Works toupdate = wList[0];
//toupdate.WorkName = "Sourdough Starters and Second Chances";
//wdb.Update(toupdate);
//int x = wdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");

Tags_On_WorksDB towdb = new();
Tags_On_WorksList towList = towdb.SelectAll();
foreach (var tow in towList)
{
    Console.WriteLine(tow.WorkTags.Tagname);
}
Tags_On_Works toupdate = towList[0];
toupdate.WorkTags = Tlist[10];
towdb.Update(toupdate);
int x = towdb.SaveChanges();
Console.WriteLine($"{x} rows were updated");
foreach (var tow in towList)
{
    Console.WriteLine(tow.WorkTags.Tagname);
}