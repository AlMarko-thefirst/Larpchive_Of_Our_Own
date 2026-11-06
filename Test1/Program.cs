using ViewModel;
using Larpchive_Of_Our_Own;
//#region
//Console.WriteLine($"======Select======");
//TagsDB tags = new TagsDB();
//TagList Tlist = tags.SelectAll();
//TagsDB tdb = new TagsDB();
//foreach (Tags t in Tlist)
//{
//    Console.WriteLine($"{t.Tagname}");
//}

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Insert======");
//Tags myTag = new Tags() { Tagname = "magic" };
//tdb.Insert(myTag);
//int x = tdb.SaveChanges();
//Console.WriteLine($"{x} rows inserted");

//Tlist = tags.SelectAll();
//Console.WriteLine($"{Tlist.Last().Tagname}");

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Update======");
//TagList tList = tdb.SelectAll();
//Tags toupdate = tList.Last();
//toupdate.Tagname = "Magic";
//tdb.Update(toupdate);
//int y = tdb.SaveChanges();
//Console.WriteLine($"{y} rows were updated");


//tList = tags.SelectAll();
//Console.WriteLine($"{tList.Last().Tagname}");

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Delete======");
//Tags Deletevar = tList.Last();
//tdb.Delete(Deletevar);
//int z = tdb.SaveChanges();
//Console.WriteLine($"{z} rows were deleted");

//tList = tags.SelectAll();
//foreach (var t in tList)
//{
//    Console.WriteLine($"{t.Tagname}");
//}
//#endregion

//#region
//Console.WriteLine($"======Select======");
//AgeRatingDB ar = new AgeRatingDB();
//AgeRatingList ARlist = ar.SelectAll();
//AgeRatingDB ardb = new AgeRatingDB();
//foreach (AgeRating Ar in ARlist)
//{
//    Console.WriteLine($"{Ar.Age_Rating}");
//}

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Insert======");
//AgeRating myAr = new AgeRating() { Age_Rating = "family friendly" };
//ar.Insert(myAr);
//int x = ar.SaveChanges();
//Console.WriteLine($"{x} rows inserted");

//ARlist = ar.SelectAll();
//Console.WriteLine($"{ARlist.Last().Age_Rating}");

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Update======");
//AgeRatingList arList = ardb.SelectAll();
//AgeRating toupdate = arList.Last();
//toupdate.Age_Rating = "Family Friendly";
//ardb.Update(toupdate);
//int y = ardb.SaveChanges();
//Console.WriteLine($"{y} rows were updated");


//arList = ar.SelectAll();
//Console.WriteLine($"{arList.Last().Age_Rating}");

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Delete======");
//AgeRating Deletevar = arList.Last();
//ardb.Delete(Deletevar);
//int z = ardb.SaveChanges();
//Console.WriteLine($"{z} rows were deleted");

//arList = ar.SelectAll();
//foreach (var Ar in arList)
//{
//    Console.WriteLine($"{Ar.Age_Rating}");
//}
//#endregion

//#region
//Console.WriteLine($"======Select======");
//PrivacyDB p = new PrivacyDB();
//PrivacyList Plist = p.SelectAll();
//PrivacyDB pdb = new PrivacyDB();
//foreach (Privacy P in Plist)
//{
//    Console.WriteLine($"{P.PrivacyLevel}");
//}

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Insert======");
//Privacy myP = new Privacy() { PrivacyLevel = "link only" };
//p.Insert(myP);
//int x = p.SaveChanges();
//Console.WriteLine($"{x} rows inserted");

//Plist = p.SelectAll();
//Console.WriteLine($"{Plist.Last().PrivacyLevel}");

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Update======");
//PrivacyList pList = pdb.SelectAll();
//Privacy toupdate = pList.Last();
//toupdate.PrivacyLevel = "Link Only";
//pdb.Update(toupdate);
//int y = pdb.SaveChanges();
//Console.WriteLine($"{y} rows were updated");


//pList = p.SelectAll();
//Console.WriteLine($"{pList.Last().PrivacyLevel}");

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Delete======");
//Privacy Deletevar = pList.Last();
//pdb.Delete(Deletevar);
//int z = pdb.SaveChanges();
//Console.WriteLine($"{z} rows were deleted");

//pList = p.SelectAll();
//foreach (var P in pList)
//{
//    Console.WriteLine($"{P.PrivacyLevel}");
//}
//#endregion

//#region
//Console.WriteLine($"======Select======");
//LanguagesDB l = new LanguagesDB();
//LanguageList Llist = l.SelectAll();
//LanguagesDB ldb = new LanguagesDB();
//foreach (Languages L in Llist)
//{
//    Console.WriteLine($"{L.LanguageNameInEnglish}");
//}

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Insert======");
//Languages myL = new Languages() { LanguageNameInEnglish = "kinyarwanda", LanguageNameInOriginalLangauge = "", LettersInAlpabetticalOrder = "" };
//l.Insert(myL);
//int x = l.SaveChanges();
//Console.WriteLine($"{x} rows inserted");

//Llist = l.SelectAll();
//Console.WriteLine($"{Llist.Last().LanguageNameInEnglish}");

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Update======");
//LanguageList lList = ldb.SelectAll();
//Languages toupdate = lList.Last();
//toupdate.LanguageNameInEnglish = "Kinyarwanda";
//ldb.Update(toupdate);
//int y = ldb.SaveChanges();
//Console.WriteLine($"{y} rows were updated");


//lList = l.SelectAll();
//Console.WriteLine($"{lList.Last().LanguageNameInEnglish}");

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Delete======");
//Languages Deletevar = lList.Last();
//ldb.Delete(Deletevar);
//int z = ldb.SaveChanges();
//Console.WriteLine($"{z} rows were deleted");

//lList = l.SelectAll();
//foreach (var L in lList)
//{
//    Console.WriteLine($"{L.LanguageNameInEnglish}");
//}
//#endregion

//#region
//Console.WriteLine($"======Select======");
//ChaptersDB ch = new ChaptersDB();
//ChapterList CHlist = ch.SelectAll();
//ChaptersDB chdb = new ChaptersDB();
//foreach (Chapters CH in CHlist)
//{
//    Console.WriteLine($"{CH.ChapterName}");
//}

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Insert======");
//Chapters myCH = new Chapters() { ChapterName = "sMalik", ChapterNum = 2, Notes = "", Story="", Summary="", WorkID=2  };
//ch.Insert(myCH);
//int x = ch.SaveChanges();
//Console.WriteLine($"{x} rows inserted");

//CHlist = ch.SelectAll();
//Console.WriteLine($"{CHlist.Last().ChapterName}");

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Update======");
//ChapterList chList = chdb.SelectAll();
//Chapters toupdate = chList.Last();
//toupdate.ChapterName = "Smolik";
//chdb.Update(toupdate);
//int y = chdb.SaveChanges();
//Console.WriteLine($"{y} rows were updated");


//chList = ch.SelectAll();
//Console.WriteLine($"{chList.Last().ChapterName}");

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Delete======");
//Chapters Deletevar = chList.Last();
//chdb.Delete(Deletevar);
//int z = chdb.SaveChanges();
//Console.WriteLine($"{z} rows were deleted");

//chList = ch.SelectAll();
//foreach (var CH in chList)
//{
//    Console.WriteLine($"{CH.ChapterName}");
//}
//#endregion

//#region 
//Console.WriteLine($"======Select======");
//CommentsDB c = new CommentsDB();
//CommentList Clist = c.SelectAll();
//CommentsDB cdb = new CommentsDB();
//foreach (Comments C in Clist)
//{
//    Console.WriteLine($"{C.Comment}");
//}

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Insert======");
//Comments myC = new Comments() { Comment = "blablabla", UserId = 3, WorkId = 2, DateOfComment = new DateTime(25 / 5 / 2005), Rating = 5 };
//c.Insert(myC);
//int x = c.SaveChanges();
//Console.WriteLine($"{x} rows inserted");

//Clist = c.SelectAll();
//Console.WriteLine($"{Clist.Last().Comment}");

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Update======");
//CommentList cList = cdb.SelectAll();
//Comments toupdate = cList.Last();
//toupdate.Comment = "Bla Bla Bla";
//cdb.Update(toupdate);
//int y = cdb.SaveChanges();
//Console.WriteLine($"{y} rows were updated");


//cList = c.SelectAll();
//Console.WriteLine($"{cList.Last().Comment}");

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Delete======");
//Comments Deletevar = cList.Last();
//cdb.Delete(Deletevar);
//int z = cdb.SaveChanges();
//Console.WriteLine($"{z} rows were deleted");

//cList = c.SelectAll();
//foreach (var CH in cList)
//{
//    Console.WriteLine($"{CH.Comment}");
//}
//#endregion

//#region 
//Console.WriteLine($"======Select======");
//UsersDB u = new UsersDB();
//UserList Ulist = u.SelectAll();
//UsersDB udb = new UsersDB();
//foreach (Users U in Ulist)
//{
//    Console.WriteLine($"{U.Username}");
//}

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Insert======");
//Users myU = new Users() { Email = "MikeHawk@gmail.com", Username = "mike", DateOfCreation = new DateTime(23 / 2 / 2024) };
//u.Insert(myU);
//int x = u.SaveChanges();
//Console.WriteLine($"{x} rows inserted");

//Ulist = u.SelectAll();
//Console.WriteLine($"{Ulist.Last().Username}");

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Update======");
//UserList uList = udb.SelectAll();
//Users toupdate = uList.Last();
//toupdate.Username = "Mike";
//udb.Update(toupdate);
//int y = udb.SaveChanges();
//Console.WriteLine($"{y} rows were updated");


//uList = u.SelectAll();
//Console.WriteLine($"{uList.Last().Username}");

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Delete======");
//Users Deletevar = uList.Last();
//udb.Delete(Deletevar);
//int z = udb.SaveChanges();
//Console.WriteLine($"{z} rows were deleted");

//uList = u.SelectAll();
//foreach (var U in uList)
//{
//    Console.WriteLine($"{U.Username}");
//}
//#endregion

#region 
Console.WriteLine($"======Select======");
WorksDB w = new();
WorksList Wlist = w.SelectAll();
WorksDB wdb = new WorksDB();
foreach (Works W in Wlist)
{
    Console.WriteLine($"{W.WorkName}");
}
Task.Delay(2000).Wait();

Console.WriteLine($"======Insert======");
LanguagesDB l = new LanguagesDB();  
LanguageList LList = l.SelectAll();
UsersDB u = new UsersDB();
UserList UList = u.SelectAll();
PrivacyDB p = new PrivacyDB();
PrivacyList PList = p.SelectAll();
AgeRatingDB ar = new AgeRatingDB();
AgeRatingList ARList = ar.SelectAll();

Works myW = new Works() { WorkName = "slimki", Description = "shlomki is an edghoge", ChapterGoal = "69", Language = LList[2], Author = UList[5], DateOfRelease = new DateTime(2007, 3, 5), Privacy = PList[0], AgeRating = ARList[2] };
w.Insert(myW);
int x = w.SaveChanges();
Console.WriteLine($"{x} rows inserted");

Wlist = w.SelectAll();
Console.WriteLine($"{Wlist.Max(x => x.Id).WorkName}");

Task.Delay(2000).Wait();

Console.WriteLine($"======Update======");
WorksList wList = wdb.SelectAll();
Works toupdate = wList.Last();
toupdate.WorkName = "Slomki";
wdb.Update(toupdate);
int y = wdb.SaveChanges();
Console.WriteLine($"{y} rows were updated");


wList = w.SelectAll();
Console.WriteLine($"{wList.Last().WorkName}");

Task.Delay(2000).Wait();

Console.WriteLine($"======Delete======");
Works Deletevar = wList.Last();
wdb.Delete(Deletevar);
int z = wdb.SaveChanges();
Console.WriteLine($"{z} rows were deleted");

wList = w.SelectAll();
foreach (var W in wList)
{
    Console.WriteLine($"{W.WorkName}");
}
#endregion

//#region
//#endregion
//#region
//Tags_On_WorksDB towdb = new();
//Tags_On_WorksList towList = towdb.SelectAll();
//foreach (Tags_On_Works w in towList)
//{
//#endregion
//#region
//AdminDB adb = new();
//AdminList aList = adb.SelectAll();
//foreach (Admin a in wList)
//    Console.WriteLine($"{a.Id}, {a.Email}, {a.Username}, {a.DateOfCreation}, {a.IsVerified}");
//#endregion
//    Console.WriteLine($"{w.Id}: {w.WorkId.WorkName}, {w.WorkTags.Tagname}");
//}
//#endregion

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
//Tags_On_WorksDB towdb = new();
//Tags_On_WorksList towList = towdb.SelectAll();
//foreach (var tow in towList)
//{
//    Console.WriteLine(tow.WorkTags.Tagname);
//}
//Tags_On_Works toupdate = towList[0];
//toupdate.WorkTags = Tlist[10];
//towdb.Update(toupdate);
//int x = towdb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//foreach (var tow in towList)
//{
//    Console.WriteLine(tow.WorkTags.Tagname);
//}

//AdminDB adb = new();
//AdminList aList = adb.SelectAll();]
//foreach (var a in aList)
//{
//    Console.WriteLine(a.Username);
//}
//Admin toupdate = aList[0];
//toupdate.Username = "Denomant";
//adb.Update(toupdate);
//int x = adb.SaveChanges();
//Console.WriteLine($"{x} rows were updated");
//foreach (var a in aList)
//{
//    Console.WriteLine(a.Username);
//}

//UsersDB udb = new();
//Users myAR = new Users() { Email = "MikeHawk@gmail.com", Username = "Mike", DateOfCreation = new DateTime(23 / 2 / 2024) };
//udb.Insert(myAR);
//int x = udb.SaveChanges();
//Console.WriteLine($"{x} rows inserted");
//foreach (var u in UList)
//{
//    Console.WriteLine($"{u.Id}: {u.Email}, {u.Username}, {u.DateOfCreation}");
//}


//WorksDB pdb = new();
//Works myAR = new Works() { WorkName="slimki", Description="shlomki is an edghoge", ChapterGoal="69",Language = LList[2], Author = UList[5], DateOfRelease = new DateTime(2007,3,5), Privacy = PList[0], AgeRating = AList[2],  };
//pdb.Insert(myAR);
//int x = pdb.SaveChanges();
//Console.WriteLine($"{x} rows inserted");
//foreach (var w in wList)
//{
//    Console.WriteLine($"{w.Id}: {w.WorkName}, {w.Description}, {w.ChapterGoal}, {w.Language}, {w.Author}, {w.DateOfRelease}, {w.Privacy}, {w.AgeRating}");
//}

//Tags_On_WorksDB pdb = new();
//Tags_On_Works myAR = new Tags_On_Works() { WorkId = wList[10], WorkTags = Tlist[2] };
//pdb.Insert(myAR);
//int x = pdb.SaveChanges();
//Console.WriteLine($"{x} rows inserted");
//foreach (var tow in towList)
//{
//    Console.WriteLine($"{tow.Id}: {tow.WorkId.Id}, {tow.WorkTags.Tagname}");
//}

//AdminDB pdb = new();
//Admin myAR = new Admin() { Id = 13, Email = "RandomKid@gmail.com", Username = "Sunna", DateOfCreation = new DateTime(2018,12,05), IsVerified = true };
//pdb.Insert(myAR);
//int x = pdb.SaveChanges();
//Console.WriteLine($"{x} rows inserted");
//foreach (var a in aList)
//{
//    Console.WriteLine($"{a.Id}: {a.Email}, {a.Username}, {a.DateOfCreation}, {a.IsVerified}");
//}


//Console.WriteLine($"======Delete======");
//Languages Deletevar = LList.Last();
//ldb.Delete(Deletevar);
//int x = ldb.SaveChanges();
//Console.WriteLine($"{x} rows were deleted");

//Console.WriteLine($"======Delete======");
//Comments Deletevar = CommentList.Last();
//cdb.Delete(Deletevar);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows were deleted");

//Console.WriteLine($"======Delete======");
//Chapters Deletevar = CList.Last();
//chdb.Delete(Deletevar);
//int x = chdb.SaveChanges();
//Console.WriteLine($"{x} rows were deleted");

//Console.WriteLine($"======Delete======");
//Works Deletevar = wList.Last();
//wdb.Delete(Deletevar);
//int x = wdb.SaveChanges();
//Console.WriteLine($"{x} rows were deleted");

//Console.WriteLine($"======Delete======");
//Tags_On_Works Deletevar = towList.Last();
//towdb.Delete(Deletevar);
//int x = towdb.SaveChanges();
//Console.WriteLine($"{x} rows were deleted");

//Console.WriteLine($"======Delete======");
//Users Deletevar = UList.Last();
//udb.Delete(Deletevar);
//int x = udb.SaveChanges();
//Console.WriteLine($"{x} rows were deleted");

//Console.WriteLine($"======Delete======");
//Admin Deletevar = aList.Last();
//adb.Delete(Deletevar);
//int x = adb.SaveChanges();
//Console.WriteLine($"{x} rows were deleted");