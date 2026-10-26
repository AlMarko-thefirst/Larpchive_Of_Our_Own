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
WorksDB wdb = new();
WorksList wList = wdb.SelectAll();
//foreach (Works w in wList)
//    Console.WriteLine($"{w.Id}: {w.WorkName}, {w.Description}, {w.ChapterGoal}, {w.Langauge}, {w.Author}, {w.DateOfRealease}, {w.Privacy}, {w.AgeRating}");
//#endregion
//#region
Tags_On_WorksDB towdb = new();
Tags_On_WorksList towList = towdb.SelectAll();
//foreach (Tags_On_Works w in towList)
//{
//#endregion
//#region
AdminDB adb = new();
AdminList aList = adb.SelectAll();
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
//Tags toupdate = tList[14];
//toupdate.Tagname = "Magic";
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
//Privacy toupdate = pList[2];
//toupdate.PrivacyLevel = "Nobody";
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
//Chapters toupdate = cList[10];
//toupdate.ChapterName = "NonCanon#1";
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

//TagsDB tdb = new();
//Tags myTag = new Tags() { Tagname = "magic" };
//tdb.Insert(myTag);
//int x = tdb.SaveChanges();
//Console.WriteLine($"{x} rows inserted");

//AgeRatingDB adb = new();
//AgeRating myAR = new AgeRating() { Age_Rating = "Restricted" };
//adb.Insert(myAR);
//int x = adb.SaveChanges();
//foreach (var a in AList)
//{
//    Console.WriteLine(a.Age_Rating);
//}

//ChaptersDB cdb = new();
//Chapters myAR = new Chapters() { ChapterName = "Restricted", WorkID = 3, ChapterNum = 2, Summary = "breh", Notes = "Idk", Story = "One little pigeon sitting on a tree, the rest got shot by kfc" };
//cdb.Insert(myAR);
//int x = cdb.SaveChanges();
//foreach (var c in CList)
//{
//    Console.WriteLine($"{c.Id}: {c.ChapterName}, {c.WorkID}, {c.ChapterNum}, {c.Summary}, {c.Notes}, {c.Story}");
//}
//CommentsDB cdb = new();
//Comments myAR = new Comments() { Comment = "disgraceful work of art, absolutely unfathomable", UserId = 3, WorkId = 2, DateOfComment = new DateTime(25 / 5 / 2005), Rating = 5 };
//cdb.Insert(myAR);
//int x = cdb.SaveChanges();
//Console.WriteLine($"{x} rows inserted");
//foreach (var c in CommentList)
//{
//    Console.WriteLine($"{c.Id}: {c.Comment}, {c.UserId}, {c.WorkId}, {c.DateOfComment}, {c.Rating}");
//}

//LanguagesDB ldb = new();
//Languages myAR = new Languages() { LanguageNameInEnglish = "amharic", LanguageNameInOriginalLangauge = "አማርኛ", LettersInAlpabetticalOrder = "ሀ ለ ሐ መ ሠ ረ ሰ ሸ ቀ በ ተ ቸ ኀ ነ ኘ አ ከ ኸ ወ ዐ ዘ ዠ የ ደ ጀ ገ ጠ ጨ ጰ ጸ ፀ ፈ ፐ" };
//ldb.Insert(myAR);
//int x = ldb.SaveChanges();
//Console.WriteLine($"{x} rows inserted");
//foreach (var l in LList)
//{
//    Console.WriteLine($"{l.Id}: {l.LanguageNameInEnglish}, {l.LanguageNameInOriginalLangauge}, {l.LettersInAlpabetticalOrder}");
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

//PrivacyDB pdb = new();
//Privacy myAR = new Privacy() { PrivacyLevel = "Link Only" };
//pdb.Insert(myAR);
//int x = pdb.SaveChanges();
//Console.WriteLine($"{x} rows inserted");
//foreach (var p in PList)
//{
//    Console.WriteLine($"{p.Id}: {p.PrivacyLevel}");
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