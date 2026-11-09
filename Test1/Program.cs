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

//#region 
//Console.WriteLine($"======Select======");
//WorksDB w = new();
//WorksList Wlist = w.SelectAll();
//WorksDB wdb = new WorksDB();
//foreach (Works W in Wlist)
//{
//    Console.WriteLine($"{W.WorkName}");
//}
//Task.Delay(2000).Wait();

//Console.WriteLine($"======Insert======");
//LanguagesDB l = new LanguagesDB();  
//LanguageList LList = l.SelectAll();
//UsersDB u = new UsersDB();
//UserList UList = u.SelectAll();
//PrivacyDB p = new PrivacyDB();
//PrivacyList PList = p.SelectAll();
//AgeRatingDB ar = new AgeRatingDB();
//AgeRatingList ARList = ar.SelectAll();

//Works myW = new Works() { WorkName = "slimki", Description = "shlomki is an edghoge", ChapterGoal = "69", Language = LList[2], Author = UList[5], DateOfRelease = new DateTime(2007, 3, 5), Privacy = PList[0], AgeRating = ARList[2] };
//w.Insert(myW);
//int x = w.SaveChanges();
//Console.WriteLine($"{x} rows inserted");

//Wlist = w.SelectAll();
//Console.WriteLine($"{Wlist.MaxBy(x => x.Id).WorkName}");

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Update======");
//WorksList wList = wdb.SelectAll();
//Works toupdate = wList.MaxBy(x => x.Id);
//toupdate.WorkName = "Slomki";
//wdb.Update(toupdate);
//int y = wdb.SaveChanges();
//Console.WriteLine($"{y} rows were updated");


//wList = w.SelectAll();
//Console.WriteLine($"{wList.MaxBy(x => x.Id).WorkName}");

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Delete======");
//Works Deletevar = wList.MaxBy(x => x.Id);
//wdb.Delete(Deletevar);
//int z = wdb.SaveChanges();
//Console.WriteLine($"{z} rows were deleted");

//wList = w.SelectAll();
//foreach (var W in wList)
//{
//    Console.WriteLine($"{W.WorkName}");
//}
//#endregion

//#region 
//Console.WriteLine($"======Select======");
//Tags_On_WorksDB tow = new();
//Tags_On_WorksList TOWlist = tow.SelectAll();
//Tags_On_WorksDB towdb = new Tags_On_WorksDB();
//foreach (Tags_On_Works TOW in TOWlist)
//{
//    Console.WriteLine($"{TOW.WorkTags.Tagname}");
//}
//Task.Delay(2000).Wait();

//Console.WriteLine($"======Insert======");
//WorksDB w = new WorksDB();
//WorksList WList = w.SelectAll();
//TagsDB t = new TagsDB();
//TagList TList = t.SelectAll();

//Tags_On_Works myTOW = new Tags_On_Works() { WorkId = WList[4], WorkTags = TList[4] };
//tow.Insert(myTOW);
//int x = tow.SaveChanges();
//Console.WriteLine($"{x} rows inserted");

//TOWlist = tow.SelectAll();
//Console.WriteLine($"{TOWlist.MaxBy(x => x.Id).WorkTags.Tagname}");

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Update======");
//Tags_On_WorksList towList = towdb.SelectAll();
//Tags_On_Works toupdate = towList.MaxBy(x => x.Id);
//toupdate.WorkTags = TList[5];
//towdb.Update(toupdate);
//int y = towdb.SaveChanges();
//Console.WriteLine($"{y} rows were updated");


//towList = tow.SelectAll();
//Console.WriteLine($"{towList.MaxBy(x => x.Id).WorkTags.Tagname}");

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Delete======");
//Tags_On_Works Deletevar = towList.MaxBy(x => x.Id);
//towdb.Delete(Deletevar);
//int z = towdb.SaveChanges();
//Console.WriteLine($"{z} rows were deleted");

//towList = tow.SelectAll();
//foreach (var TOW in towList)
//{
//    Console.WriteLine($"{TOW.WorkTags.Tagname}");
//}
//#endregion

//#region 
//Console.WriteLine($"======Select======");
//AdminDB a = new();
//AdminList Alist = a.SelectAll();
//AdminDB adb = new AdminDB();
//foreach (Admin A in Alist)
//{
//    Console.WriteLine($"{A.Email}, {A.Username}, {A.DateOfCreation}, {A.IsVerified}");
//}
//Task.Delay(2000).Wait();

//Console.WriteLine($"======Insert======");
//Admin myAR = new Admin() { Id = 13, Email = "RandomKid@gmail.com", Username = "Sunna", DateOfCreation = new DateTime(2018, 12, 05), IsVerified = true };
//adb.Insert(myAR);
//int x = adb.SaveChanges();
//Console.WriteLine($"{x} rows inserted");

//Alist = a.SelectAll();
//Console.WriteLine($"{Alist.MaxBy(x => x.Id).Email}, {Alist.MaxBy(x => x.Id).Username}, {Alist.MaxBy(x => x.Id).DateOfCreation}, {Alist.MaxBy(x => x.Id).IsVerified}");

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Update======");
//AdminList aList = a.SelectAll();
//Admin toupdate = aList.MaxBy(x => x.Id);
//toupdate.Username = "Random kid";
//adb.Update(toupdate);
//int y = adb.SaveChanges();
//Console.WriteLine($"{y} rows were updated");


//aList = null; 
//aList = a.SelectAll();
//Console.WriteLine($"{aList.MaxBy(x => x.Id).Email}, {aList.MaxBy(x => x.Id).Username}, {aList.MaxBy(x => x.Id).DateOfCreation}, {aList.MaxBy(x => x.Id).IsVerified}");

//Task.Delay(2000).Wait();

//Console.WriteLine($"======Delete======");
//Admin Deletevar = aList.MaxBy(x => x.Id);
//adb.Delete(Deletevar);
//int z = adb.SaveChanges();
//Console.WriteLine($"{z} rows were deleted");

//aList = a.SelectAll();
//foreach (var A in aList)
//{
//    Console.WriteLine($"{A.Email}, {A.Username}, {A.DateOfCreation}, {A.IsVerified}");
//}
//#endregion