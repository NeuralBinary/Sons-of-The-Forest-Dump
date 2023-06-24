using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using Pathfinding.Ionic.Zlib;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	[ComVisible(true)]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00005")]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	public class ZipFile : IEnumerable<ZipEntry>, IDisposable, IEnumerable
	{
		// Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x28682C0", Offset = "0x28668C0", VA = "0x1828682C0")]
		public ZipFile(string fileName)
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x28684B0", Offset = "0x2866AB0", VA = "0x1828684B0")]
		public ZipFile(string fileName, Encoding encoding)
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2868710", Offset = "0x2866D10", VA = "0x182868710")]
		public ZipFile()
		{
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2868890", Offset = "0x2866E90", VA = "0x182868890")]
		public ZipFile(Encoding encoding)
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2868A90", Offset = "0x2867090", VA = "0x182868A90")]
		public ZipFile(string fileName, TextWriter statusMessageWriter)
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2868CA0", Offset = "0x28672A0", VA = "0x182868CA0")]
		public ZipFile(string fileName, TextWriter statusMessageWriter, Encoding encoding)
		{
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600018A RID: 394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public event EventHandler<SaveProgressEventArgs> SaveProgress
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x2868FC0", Offset = "0x28675C0", VA = "0x182868FC0")]
			add
			{
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x2869170", Offset = "0x2867770", VA = "0x182869170")]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public event EventHandler<ReadProgressEventArgs> ReadProgress
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x2869320", Offset = "0x2867920", VA = "0x182869320")]
			add
			{
			}
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x28694D0", Offset = "0x2867AD0", VA = "0x1828694D0")]
			remove
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000003")]
		public event EventHandler<ExtractProgressEventArgs> ExtractProgress
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x2869680", Offset = "0x2867C80", VA = "0x182869680")]
			add
			{
			}
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x2869830", Offset = "0x2867E30", VA = "0x182869830")]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600018F RID: 399 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000004")]
		public event EventHandler<AddProgressEventArgs> AddProgress
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x28699E0", Offset = "0x2867FE0", VA = "0x1828699E0")]
			add
			{
			}
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x2869B90", Offset = "0x2868190", VA = "0x182869B90")]
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000191 RID: 401 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000192 RID: 402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000005")]
		public event EventHandler<ZipErrorEventArgs> ZipError
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x2869D40", Offset = "0x2868340", VA = "0x182869D40")]
			add
			{
			}
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x2869EF0", Offset = "0x28684F0", VA = "0x182869EF0")]
			remove
			{
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x286A0A0", Offset = "0x28686A0", VA = "0x18286A0A0", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x286A0B0", Offset = "0x28686B0", VA = "0x18286A0B0")]
		public ZipEntry AddItem(string fileOrDirectoryName)
		{
			return null;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x286A1B0", Offset = "0x28687B0", VA = "0x18286A1B0")]
		public ZipEntry AddItem(string fileOrDirectoryName, string directoryPathInArchive)
		{
			return null;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x286A2D0", Offset = "0x28688D0", VA = "0x18286A2D0")]
		public ZipEntry AddFile(string fileName)
		{
			return null;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x286A2E0", Offset = "0x28688E0", VA = "0x18286A2E0")]
		public ZipEntry AddFile(string fileName, string directoryPathInArchive)
		{
			return null;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x286A3A0", Offset = "0x28689A0", VA = "0x18286A3A0")]
		public void RemoveEntries(ICollection<ZipEntry> entriesToRemove)
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x286A5A0", Offset = "0x2868BA0", VA = "0x18286A5A0")]
		public void RemoveEntries(ICollection<string> entriesToRemove)
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x286A7A0", Offset = "0x2868DA0", VA = "0x18286A7A0")]
		public void AddFiles(IEnumerable<string> fileNames)
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x286A7C0", Offset = "0x2868DC0", VA = "0x18286A7C0")]
		public void UpdateFiles(IEnumerable<string> fileNames)
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x286A7D0", Offset = "0x2868DD0", VA = "0x18286A7D0")]
		public void AddFiles(IEnumerable<string> fileNames, string directoryPathInArchive)
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x286A7F0", Offset = "0x2868DF0", VA = "0x18286A7F0")]
		public void AddFiles(IEnumerable<string> fileNames, bool preserveDirHierarchy, string directoryPathInArchive)
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x286AB00", Offset = "0x2869100", VA = "0x18286AB00")]
		public void UpdateFiles(IEnumerable<string> fileNames, string directoryPathInArchive)
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x286AD20", Offset = "0x2869320", VA = "0x18286AD20")]
		public ZipEntry UpdateFile(string fileName)
		{
			return null;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x286AD30", Offset = "0x2869330", VA = "0x18286AD30")]
		public ZipEntry UpdateFile(string fileName, string directoryPathInArchive)
		{
			return null;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x286ADE0", Offset = "0x28693E0", VA = "0x18286ADE0")]
		public ZipEntry UpdateDirectory(string directoryName)
		{
			return null;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x286AE50", Offset = "0x2869450", VA = "0x18286AE50")]
		public ZipEntry UpdateDirectory(string directoryName, string directoryPathInArchive)
		{
			return null;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x286AED0", Offset = "0x28694D0", VA = "0x18286AED0")]
		public void UpdateItem(string itemName)
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x286AFD0", Offset = "0x28695D0", VA = "0x18286AFD0")]
		public void UpdateItem(string itemName, string directoryPathInArchive)
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x286B0F0", Offset = "0x28696F0", VA = "0x18286B0F0")]
		public ZipEntry AddEntry(string entryName, string content)
		{
			return null;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x286B140", Offset = "0x2869740", VA = "0x18286B140")]
		public ZipEntry AddEntry(string entryName, string content, Encoding encoding)
		{
			return null;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x286B260", Offset = "0x2869860", VA = "0x18286B260")]
		public ZipEntry AddEntry(string entryName, Stream stream)
		{
			return null;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x286B3C0", Offset = "0x28699C0", VA = "0x18286B3C0")]
		public ZipEntry AddEntry(string entryName, WriteDelegate writer)
		{
			return null;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x286B4B0", Offset = "0x2869AB0", VA = "0x18286B4B0")]
		public ZipEntry AddEntry(string entryName, OpenDelegate opener, CloseDelegate closer)
		{
			return null;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x286B610", Offset = "0x2869C10", VA = "0x18286B610")]
		private ZipEntry _InternalAddEntry(ZipEntry ze)
		{
			return null;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x286B840", Offset = "0x2869E40", VA = "0x18286B840")]
		public ZipEntry UpdateEntry(string entryName, string content)
		{
			return null;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x286B8B0", Offset = "0x2869EB0", VA = "0x18286B8B0")]
		public ZipEntry UpdateEntry(string entryName, string content, Encoding encoding)
		{
			return null;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x286B910", Offset = "0x2869F10", VA = "0x18286B910")]
		public ZipEntry UpdateEntry(string entryName, WriteDelegate writer)
		{
			return null;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x286BA00", Offset = "0x286A000", VA = "0x18286BA00")]
		public ZipEntry UpdateEntry(string entryName, OpenDelegate opener, CloseDelegate closer)
		{
			return null;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x286BB70", Offset = "0x286A170", VA = "0x18286BB70")]
		public ZipEntry UpdateEntry(string entryName, Stream stream)
		{
			return null;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x286BBB0", Offset = "0x286A1B0", VA = "0x18286BBB0")]
		private void RemoveEntryForUpdate(string entryName)
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x286BCF0", Offset = "0x286A2F0", VA = "0x18286BCF0")]
		public ZipEntry AddEntry(string entryName, byte[] byteContent)
		{
			return null;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x286BDD0", Offset = "0x286A3D0", VA = "0x18286BDD0")]
		public ZipEntry UpdateEntry(string entryName, byte[] byteContent)
		{
			return null;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x286BEC0", Offset = "0x286A4C0", VA = "0x18286BEC0")]
		public ZipEntry AddDirectory(string directoryName)
		{
			return null;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x286BF30", Offset = "0x286A530", VA = "0x18286BF30")]
		public ZipEntry AddDirectory(string directoryName, string directoryPathInArchive)
		{
			return null;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x286BFB0", Offset = "0x286A5B0", VA = "0x18286BFB0")]
		public ZipEntry AddDirectoryByName(string directoryNameInArchive)
		{
			return null;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x286C200", Offset = "0x286A800", VA = "0x18286C200")]
		private ZipEntry AddOrUpdateDirectoryImpl(string directoryName, string rootDirectoryPathInArchive, AddOrUpdateAction action)
		{
			return null;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x286C290", Offset = "0x286A890", VA = "0x18286C290")]
		internal void InternalAddEntry(string name, ZipEntry entry)
		{
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x286C370", Offset = "0x286A970", VA = "0x18286C370")]
		private ZipEntry AddOrUpdateDirectoryImpl(string directoryName, string rootDirectoryPathInArchive, AddOrUpdateAction action, bool recurse, int level)
		{
			return null;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x286C8A0", Offset = "0x286AEA0", VA = "0x18286C8A0")]
		public static bool CheckZip(string zipFileName)
		{
			return default(bool);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x286C8F0", Offset = "0x286AEF0", VA = "0x18286C8F0")]
		public static bool CheckZip(string zipFileName, bool fixIfNecessary, TextWriter writer)
		{
			return default(bool);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x286D010", Offset = "0x286B610", VA = "0x18286D010")]
		public static void FixZipDirectory(string zipFileName)
		{
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x286D120", Offset = "0x286B720", VA = "0x18286D120")]
		public static bool CheckZipPassword(string zipFileName, string password)
		{
			return default(bool);
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001BD RID: 445 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000055")]
		public string Info
		{
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x286D430", Offset = "0x286BA30", VA = "0x18286D430")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001BE RID: 446 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000056")]
		private string ArchiveNameForEvent
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x286D910", Offset = "0x286BF10", VA = "0x18286D910")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x286D950", Offset = "0x286BF50", VA = "0x18286D950")]
		internal bool OnSaveBlock(ZipEntry entry, long bytesXferred, long totalBytesToXfer)
		{
			return default(bool);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x286DB00", Offset = "0x286C100", VA = "0x18286DB00")]
		private void OnSaveEntry(int current, ZipEntry entry, bool before)
		{
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x286DC70", Offset = "0x286C270", VA = "0x18286DC70")]
		private void OnSaveEvent(ZipProgressEventType eventFlavor)
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x286DD50", Offset = "0x286C350", VA = "0x18286DD50")]
		private void OnSaveStarted()
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x286DE20", Offset = "0x286C420", VA = "0x18286DE20")]
		private void OnSaveCompleted()
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x286DEE0", Offset = "0x286C4E0", VA = "0x18286DEE0")]
		private void OnReadStarted()
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x286DFA0", Offset = "0x286C5A0", VA = "0x18286DFA0")]
		private void OnReadCompleted()
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x286E060", Offset = "0x286C660", VA = "0x18286E060")]
		internal void OnReadBytes(ZipEntry entry)
		{
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x286E220", Offset = "0x286C820", VA = "0x18286E220")]
		internal void OnReadEntry(bool before, ZipEntry entry)
		{
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x17000057")]
		private long LengthOfReadStream
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x286E410", Offset = "0x286CA10", VA = "0x18286E410")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x286E4A0", Offset = "0x286CAA0", VA = "0x18286E4A0")]
		private void OnExtractEntry(int current, bool before, ZipEntry currentEntry, string path)
		{
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x286E670", Offset = "0x286CC70", VA = "0x18286E670")]
		internal bool OnExtractBlock(ZipEntry entry, long bytesWritten, long totalBytesToWrite)
		{
			return default(bool);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x286E820", Offset = "0x286CE20", VA = "0x18286E820")]
		internal bool OnSingleEntryExtract(ZipEntry entry, string path, bool before)
		{
			return default(bool);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x286EBE0", Offset = "0x286D1E0", VA = "0x18286EBE0")]
		internal bool OnExtractExisting(ZipEntry entry, string path)
		{
			return default(bool);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x286EDF0", Offset = "0x286D3F0", VA = "0x18286EDF0")]
		private void OnExtractAllCompleted(string path)
		{
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x286EF10", Offset = "0x286D510", VA = "0x18286EF10")]
		private void OnExtractAllStarted(string path)
		{
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x286F030", Offset = "0x286D630", VA = "0x18286F030")]
		private void OnAddStarted()
		{
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x286F100", Offset = "0x286D700", VA = "0x18286F100")]
		private void OnAddCompleted()
		{
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x286F1C0", Offset = "0x286D7C0", VA = "0x18286F1C0")]
		internal void AfterAddEntry(ZipEntry entry)
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x286F320", Offset = "0x286D920", VA = "0x18286F320")]
		internal bool OnZipErrorSaving(ZipEntry entry, Exception exc)
		{
			return default(bool);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x286F5C0", Offset = "0x286DBC0", VA = "0x18286F5C0")]
		public void ExtractAll(string path)
		{
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x286F5D0", Offset = "0x286DBD0", VA = "0x18286F5D0")]
		public void ExtractAll(string path, ExtractExistingFileAction extractExistingFile)
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x286F5F0", Offset = "0x286DBF0", VA = "0x18286F5F0")]
		private void _InternalExtractAll(string path, bool overrideExtractExistingProperty)
		{
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x28703F0", Offset = "0x286E9F0", VA = "0x1828703F0")]
		public static ZipFile Read(string fileName)
		{
			return null;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2870450", Offset = "0x286EA50", VA = "0x182870450")]
		public static ZipFile Read(string fileName, ReadOptions options)
		{
			return null;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x2870530", Offset = "0x286EB30", VA = "0x182870530")]
		private static ZipFile Read(string fileName, TextWriter statusMessageWriter, Encoding encoding, EventHandler<ReadProgressEventArgs> readProgress)
		{
			return null;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x28707E0", Offset = "0x286EDE0", VA = "0x1828707E0")]
		public static ZipFile Read(Stream zipStream)
		{
			return null;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2870840", Offset = "0x286EE40", VA = "0x182870840")]
		public static ZipFile Read(Stream zipStream, ReadOptions options)
		{
			return null;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2870920", Offset = "0x286EF20", VA = "0x182870920")]
		private static ZipFile Read(Stream zipStream, TextWriter statusMessageWriter, Encoding encoding, EventHandler<ReadProgressEventArgs> readProgress)
		{
			return null;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2870C80", Offset = "0x286F280", VA = "0x182870C80")]
		private static void ReadIntoInstance(ZipFile zf)
		{
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2871210", Offset = "0x286F810", VA = "0x182871210")]
		private static void Zip64SeekToCentralDirectory(ZipFile zf)
		{
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x2871530", Offset = "0x286FB30", VA = "0x182871530")]
		private static uint ReadFirstFourBytes(Stream s)
		{
			return 0U;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x28715C0", Offset = "0x286FBC0", VA = "0x1828715C0")]
		private static void ReadCentralDirectory(ZipFile zf)
		{
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x28718C0", Offset = "0x286FEC0", VA = "0x1828718C0")]
		private static void ReadIntoInstance_Orig(ZipFile zf)
		{
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x2871D20", Offset = "0x2870320", VA = "0x182871D20")]
		private static void ReadCentralDirectoryFooter(ZipFile zf)
		{
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2872160", Offset = "0x2870760", VA = "0x182872160")]
		private static void ReadZipFileComment(ZipFile zf)
		{
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x2872300", Offset = "0x2870900", VA = "0x182872300")]
		public static bool IsZipFile(string fileName)
		{
			return default(bool);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2872350", Offset = "0x2870950", VA = "0x182872350")]
		public static bool IsZipFile(string fileName, bool testExtract)
		{
			return default(bool);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x2872480", Offset = "0x2870A80", VA = "0x182872480")]
		public static bool IsZipFile(Stream stream, bool testExtract)
		{
			return default(bool);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x2872740", Offset = "0x2870D40", VA = "0x182872740")]
		private void DeleteFileWithRetry(string filename)
		{
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2872800", Offset = "0x2870E00", VA = "0x182872800")]
		public void Save()
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x28732C0", Offset = "0x28718C0", VA = "0x1828732C0")]
		private static void NotifyEntriesSaveComplete(ICollection<ZipEntry> c)
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x28734A0", Offset = "0x2871AA0", VA = "0x1828734A0")]
		private void RemoveTempFile()
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x2873600", Offset = "0x2871C00", VA = "0x182873600")]
		private void CleanupAfterSaveOperation()
		{
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2873720", Offset = "0x2871D20", VA = "0x182873720")]
		public void Save(string fileName)
		{
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2873910", Offset = "0x2871F10", VA = "0x182873910")]
		public void Save(Stream outputStream)
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2873B10", Offset = "0x2872110", VA = "0x182873B10")]
		public void AddSelectedFiles(string selectionCriteria)
		{
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2873B70", Offset = "0x2872170", VA = "0x182873B70")]
		public void AddSelectedFiles(string selectionCriteria, bool recurseDirectories)
		{
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2873BE0", Offset = "0x28721E0", VA = "0x182873BE0")]
		public void AddSelectedFiles(string selectionCriteria, string directoryOnDisk)
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2873C10", Offset = "0x2872210", VA = "0x182873C10")]
		public void AddSelectedFiles(string selectionCriteria, string directoryOnDisk, bool recurseDirectories)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2873C40", Offset = "0x2872240", VA = "0x182873C40")]
		public void AddSelectedFiles(string selectionCriteria, string directoryOnDisk, string directoryPathInArchive)
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2873C70", Offset = "0x2872270", VA = "0x182873C70")]
		public void AddSelectedFiles(string selectionCriteria, string directoryOnDisk, string directoryPathInArchive, bool recurseDirectories)
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2873CA0", Offset = "0x28722A0", VA = "0x182873CA0")]
		public void UpdateSelectedFiles(string selectionCriteria, string directoryOnDisk, string directoryPathInArchive, bool recurseDirectories)
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2873CD0", Offset = "0x28722D0", VA = "0x182873CD0")]
		private string EnsureendInSlash(string s)
		{
			return null;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2873D40", Offset = "0x2872340", VA = "0x182873D40")]
		private void _AddOrUpdateSelectedFiles(string selectionCriteria, string directoryOnDisk, string directoryPathInArchive, bool recurseDirectories, bool wantUpdate)
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x28742C0", Offset = "0x28728C0", VA = "0x1828742C0")]
		private static string ReplaceLeadingDirectory(string original, string pattern, string replacement)
		{
			return null;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2874370", Offset = "0x2872970", VA = "0x182874370")]
		public ICollection<ZipEntry> SelectEntries(string selectionCriteria)
		{
			return null;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2874450", Offset = "0x2872A50", VA = "0x182874450")]
		public ICollection<ZipEntry> SelectEntries(string selectionCriteria, string directoryPathInArchive)
		{
			return null;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2874530", Offset = "0x2872B30", VA = "0x182874530")]
		public int RemoveSelectedEntries(string selectionCriteria)
		{
			return 0;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x28745B0", Offset = "0x2872BB0", VA = "0x1828745B0")]
		public int RemoveSelectedEntries(string selectionCriteria, string directoryPathInArchive)
		{
			return 0;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2874640", Offset = "0x2872C40", VA = "0x182874640")]
		public void ExtractSelectedEntries(string selectionCriteria)
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2874860", Offset = "0x2872E60", VA = "0x182874860")]
		public void ExtractSelectedEntries(string selectionCriteria, ExtractExistingFileAction extractExistingFile)
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2874A90", Offset = "0x2873090", VA = "0x182874A90")]
		public void ExtractSelectedEntries(string selectionCriteria, string directoryPathInArchive)
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2874CB0", Offset = "0x28732B0", VA = "0x182874CB0")]
		public void ExtractSelectedEntries(string selectionCriteria, string directoryInArchive, string extractDirectory)
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2874EB0", Offset = "0x28734B0", VA = "0x182874EB0")]
		public void ExtractSelectedEntries(string selectionCriteria, string directoryPathInArchive, string extractDirectory, ExtractExistingFileAction extractExistingFile)
		{
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00002CA0 File Offset: 0x00000EA0
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000058")]
		public bool FullScan
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x28750C0", Offset = "0x28736C0", VA = "0x1828750C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x28750D0", Offset = "0x28736D0", VA = "0x1828750D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00002CB8 File Offset: 0x00000EB8
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000059")]
		public bool SortEntriesBeforeSaving
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0xA03E00", Offset = "0xA02400", VA = "0x180A03E00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x28750E0", Offset = "0x28736E0", VA = "0x1828750E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00002CD0 File Offset: 0x00000ED0
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005A")]
		public bool AddDirectoryWillTraverseReparsePoints
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x28750F0", Offset = "0x28736F0", VA = "0x1828750F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x2875100", Offset = "0x2873700", VA = "0x182875100")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00002CE8 File Offset: 0x00000EE8
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005B")]
		public int BufferSize
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0xAFF540", Offset = "0xAFDB40", VA = "0x180AFF540")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0xAFF550", Offset = "0xAFDB50", VA = "0x180AFF550")]
			set
			{
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00002D00 File Offset: 0x00000F00
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005C")]
		public int CodecBufferSize
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x2641100", Offset = "0x263F700", VA = "0x182641100")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x2875110", Offset = "0x2873710", VA = "0x182875110")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00002D18 File Offset: 0x00000F18
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005D")]
		public bool FlattenFoldersOnExtract
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x2875120", Offset = "0x2873720", VA = "0x182875120")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x2875130", Offset = "0x2873730", VA = "0x182875130")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00002D30 File Offset: 0x00000F30
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005E")]
		public CompressionStrategy Strategy
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0xAFF2B0", Offset = "0xAFD8B0", VA = "0x180AFF2B0")]
			get
			{
				return CompressionStrategy.Default;
			}
			[Token(Token = "0x600020D")]
			[Address(RVA = "0xAFF2C0", Offset = "0xAFD8C0", VA = "0x180AFF2C0")]
			set
			{
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600020E RID: 526 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005F")]
		public string Name
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x620F20", Offset = "0x61F520", VA = "0x180620F20")]
			set
			{
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00002D48 File Offset: 0x00000F48
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000060")]
		public CompressionLevel CompressionLevel
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x2748830", Offset = "0x2746E30", VA = "0x182748830")]
			[CompilerGenerated]
			get
			{
				return CompressionLevel.None;
			}
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x2875140", Offset = "0x2873740", VA = "0x182875140")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00002D60 File Offset: 0x00000F60
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000061")]
		public CompressionMethod CompressionMethod
		{
			[Token(Token = "0x6000212")]
			[Address(RVA = "0xAFF2D0", Offset = "0xAFD8D0", VA = "0x180AFF2D0")]
			get
			{
				return CompressionMethod.None;
			}
			[Token(Token = "0x6000213")]
			[Address(RVA = "0xAFF2E0", Offset = "0xAFD8E0", VA = "0x180AFF2E0")]
			set
			{
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000214 RID: 532 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000062")]
		public string Comment
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x2875150", Offset = "0x2873750", VA = "0x182875150")]
			set
			{
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00002D78 File Offset: 0x00000F78
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000063")]
		public bool EmitTimesInWindowsFormatWhenSaving
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x9ABDB0", Offset = "0x9AA3B0", VA = "0x1809ABDB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x2586730", Offset = "0x2584D30", VA = "0x182586730")]
			set
			{
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00002D90 File Offset: 0x00000F90
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000064")]
		public bool EmitTimesInUnixFormatWhenSaving
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x2586740", Offset = "0x2584D40", VA = "0x182586740")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x2586750", Offset = "0x2584D50", VA = "0x182586750")]
			set
			{
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[Token(Token = "0x17000065")]
		internal bool Verbose
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x12AF770", Offset = "0x12ADD70", VA = "0x1812AF770")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x28751C0", Offset = "0x28737C0", VA = "0x1828751C0")]
		public bool ContainsEntry(string name)
		{
			return default(bool);
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00002DD8 File Offset: 0x00000FD8
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000066")]
		public bool CaseSensitiveRetrieval
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x642350", Offset = "0x640950", VA = "0x180642350")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x2875260", Offset = "0x2873860", VA = "0x182875260")]
			set
			{
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00002DF0 File Offset: 0x00000FF0
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000067")]
		[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete.  It will be removed in a future version of the library. Your applications should  use AlternateEncoding and AlternateEncodingUsage instead.")]
		public bool UseUnicodeAsNecessary
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x2875270", Offset = "0x2873870", VA = "0x182875270")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x28752E0", Offset = "0x28738E0", VA = "0x1828752E0")]
			set
			{
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00002E08 File Offset: 0x00001008
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000068")]
		public Zip64Option UseZip64WhenSaving
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0xAFF600", Offset = "0xAFDC00", VA = "0x180AFF600")]
			get
			{
				return Zip64Option.Default;
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0xAFF610", Offset = "0xAFDC10", VA = "0x180AFF610")]
			set
			{
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x17000069")]
		public bool? RequiresZip64
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x2875460", Offset = "0x2873A60", VA = "0x182875460")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x1700006A")]
		public bool? OutputUsedZip64
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x2875700", Offset = "0x2873D00", VA = "0x182875700")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x1700006B")]
		public bool? InputUsesZip64
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x2875710", Offset = "0x2873D10", VA = "0x182875710")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000225 RID: 549 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006C")]
		[Obsolete("use AlternateEncoding instead.")]
		public Encoding ProvisionalAlternateEncoding
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x28758D0", Offset = "0x2873ED0", VA = "0x1828758D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x28758F0", Offset = "0x2873EF0", VA = "0x1828758F0")]
			set
			{
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000227 RID: 551 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006D")]
		public Encoding AlternateEncoding
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x691530", Offset = "0x68FB30", VA = "0x180691530")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000228")]
			[Address(RVA = "0xA2FF40", Offset = "0xA2E540", VA = "0x180A2FF40")]
			set
			{
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00002E68 File Offset: 0x00001068
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006E")]
		public ZipOption AlternateEncodingUsage
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0xAFF520", Offset = "0xAFDB20", VA = "0x180AFF520")]
			get
			{
				return ZipOption.Default;
			}
			[Token(Token = "0x600022A")]
			[Address(RVA = "0xAFF530", Offset = "0xAFDB30", VA = "0x180AFF530")]
			set
			{
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600022B RID: 555 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x1700006F")]
		public static Encoding DefaultEncoding
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x2875960", Offset = "0x2873F60", VA = "0x182875960")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600022C RID: 556 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000070")]
		public TextWriter StatusMessageTextWriter
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			set
			{
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600022E RID: 558 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000071")]
		public string TempFileFolder
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x737420", Offset = "0x735A20", VA = "0x180737420")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x28759B0", Offset = "0x2873FB0", VA = "0x1828759B0")]
			set
			{
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000231 RID: 561 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000072")]
		public string Password
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
			private get
			{
				return null;
			}
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x2875A80", Offset = "0x2874080", VA = "0x182875A80")]
			set
			{
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00002E80 File Offset: 0x00001080
		// (set) Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000073")]
		public ExtractExistingFileAction ExtractExistingFile
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x2875B00", Offset = "0x2874100", VA = "0x182875B00")]
			[CompilerGenerated]
			get
			{
				return ExtractExistingFileAction.Throw;
			}
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x2875B10", Offset = "0x2874110", VA = "0x182875B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00002E98 File Offset: 0x00001098
		// (set) Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000074")]
		public ZipErrorAction ZipErrorAction
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x2875B20", Offset = "0x2874120", VA = "0x182875B20")]
			get
			{
				return ZipErrorAction.Throw;
			}
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x2875B40", Offset = "0x2874140", VA = "0x182875B40")]
			set
			{
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00002EB0 File Offset: 0x000010B0
		// (set) Token: 0x06000237 RID: 567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000075")]
		public EncryptionAlgorithm Encryption
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0xAFF3C0", Offset = "0xAFD9C0", VA = "0x180AFF3C0")]
			get
			{
				return EncryptionAlgorithm.None;
			}
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x2875BB0", Offset = "0x28741B0", VA = "0x182875BB0")]
			set
			{
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000238 RID: 568 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000076")]
		public SetCompressionCallback SetCompression
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x2875C20", Offset = "0x2874220", VA = "0x182875C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x2875C30", Offset = "0x2874230", VA = "0x182875C30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00002EC8 File Offset: 0x000010C8
		// (set) Token: 0x0600023B RID: 571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000077")]
		public int MaxOutputSegmentSize
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x670F40", Offset = "0x66F540", VA = "0x180670F40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x2875C90", Offset = "0x2874290", VA = "0x182875C90")]
			set
			{
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x17000078")]
		public int NumberOfSegmentsForMostRecentSave
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x2875D00", Offset = "0x2874300", VA = "0x182875D00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00002EF8 File Offset: 0x000010F8
		// (set) Token: 0x0600023D RID: 573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000079")]
		public long ParallelDeflateThreshold
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x8DF480", Offset = "0x8DDA80", VA = "0x1808DF480")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x2875D10", Offset = "0x2874310", VA = "0x182875D10")]
			set
			{
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00002F10 File Offset: 0x00001110
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007A")]
		public int ParallelDeflateMaxBufferPairs
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0xAFF5E0", Offset = "0xAFDBE0", VA = "0x180AFF5E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x2875D90", Offset = "0x2874390", VA = "0x182875D90")]
			set
			{
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2875E20", Offset = "0x2874420", VA = "0x182875E20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000242 RID: 578 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x1700007B")]
		public static Version LibraryVersion
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x2875E60", Offset = "0x2874460", VA = "0x182875E60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2875ED0", Offset = "0x28744D0", VA = "0x182875ED0")]
		internal void NotifyEntryChanged()
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x2875EE0", Offset = "0x28744E0", VA = "0x182875EE0")]
		internal Stream StreamForDiskNumber(uint diskNumber)
		{
			return null;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x2876080", Offset = "0x2874680", VA = "0x182876080")]
		internal void Reset(bool whileSaving)
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x2876530", Offset = "0x2874B30", VA = "0x182876530")]
		public void Initialize(string fileName)
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x28765E0", Offset = "0x2874BE0", VA = "0x1828765E0")]
		private void _initEntriesDictionary()
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x2876710", Offset = "0x2874D10", VA = "0x182876710")]
		private void _InitInstance(string zipFileName, TextWriter statusMessageWriter)
		{
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000249 RID: 585 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x1700007C")]
		private List<ZipEntry> ZipEntriesAsList
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x28768A0", Offset = "0x2874EA0", VA = "0x1828768A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007D RID: 125
		[Token(Token = "0x1700007D")]
		public ZipEntry this[int ix]
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x28769A0", Offset = "0x2874FA0", VA = "0x1828769A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007E RID: 126
		[Token(Token = "0x1700007E")]
		public ZipEntry this[string fileName]
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x2876AF0", Offset = "0x28750F0", VA = "0x182876AF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600024C RID: 588 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x1700007F")]
		public ICollection<string> EntryFileNames
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x2876C30", Offset = "0x2875230", VA = "0x182876C30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600024D RID: 589 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000080")]
		public ICollection<ZipEntry> Entries
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x2876C80", Offset = "0x2875280", VA = "0x182876C80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600024E RID: 590 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000081")]
		public ICollection<ZipEntry> EntriesSorted
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x2876CD0", Offset = "0x28752D0", VA = "0x182876CD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x17000082")]
		public int Count
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x2877000", Offset = "0x2875600", VA = "0x182877000")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x2877040", Offset = "0x2875640", VA = "0x182877040")]
		public void RemoveEntry(ZipEntry entry)
		{
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x2877180", Offset = "0x2875780", VA = "0x182877180")]
		public void RemoveEntry(string fileName)
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x2877280", Offset = "0x2875880", VA = "0x182877280", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x2877310", Offset = "0x2875910", VA = "0x182877310", Slot = "7")]
		protected virtual void Dispose(bool disposeManagedResources)
		{
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000254 RID: 596 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x17000083")]
		internal Stream ReadStream
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x2877460", Offset = "0x2875A60", VA = "0x182877460")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000255 RID: 597 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000084")]
		private Stream WriteStream
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x2877520", Offset = "0x2875B20", VA = "0x182877520")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x2877630", Offset = "0x2875C30", VA = "0x182877630")]
			set
			{
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x28776E0", Offset = "0x2875CE0", VA = "0x1828776E0", Slot = "4")]
		[DebuggerHidden]
		public IEnumerator<ZipEntry> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x286A0A0", Offset = "0x28686A0", VA = "0x18286A0A0")]
		[DispId(-4)]
		public IEnumerator GetNewEnum()
		{
			return null;
		}

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private long _lengthOfReadStream;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextWriter _StatusMessageTextWriter;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _CaseSensitiveRetrieval;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Stream _readstream;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Stream _writestream;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ushort _versionMadeBy;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private ushort _versionNeededToExtract;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private uint _diskNumberWithCd;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _maxOutputSegmentSize;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private uint _numberOfSegmentsForMostRecentSave;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ZipErrorAction _zipErrorAction;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool _disposed;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<string, ZipEntry> _entries;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<ZipEntry> _zipEntriesAsList;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string _name;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string _readName;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string _Comment;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal string _Password;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool _emitNtfsTimes;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		private bool _emitUnixTimes;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private CompressionStrategy _Strategy;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private CompressionMethod _compressionMethod;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _fileAlreadyExists;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string _temporaryFileName;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool _contentsChanged;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		private bool _hasBeenSaved;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string _TempFileFolder;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool _ReadStreamIsOurs;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private object LOCK;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool _saveOperationCanceled;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		private bool _extractOperationCanceled;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBA")]
		private bool _addOperationCanceled;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private EncryptionAlgorithm _Encryption;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool _JustSaved;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private long _locEndOfCDS;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private uint _OffsetOfCentralDirectory;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private long _OffsetOfCentralDirectory64;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool? _OutputUsesZip64;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE2")]
		internal bool _inExtractAll;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Encoding _defaultEncoding;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Encoding _alternateEncoding;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private ZipOption _alternateEncodingUsage;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private int _BufferSize;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		internal ParallelDeflateOutputStream ParallelDeflater;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private long _ParallelDeflateThreshold;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int _maxBufferPairs;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		internal Zip64Option _zip64;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private bool _SavingSfx;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int BufferSizeDefault;
	}
}
