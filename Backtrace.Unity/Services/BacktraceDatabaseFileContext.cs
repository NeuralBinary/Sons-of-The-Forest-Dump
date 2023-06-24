using System;
using System.Collections.Generic;
using System.IO;
using Backtrace.Unity.Interfaces;
using Backtrace.Unity.Model;
using Backtrace.Unity.Model.Database;
using Il2CppDummyDll;

namespace Backtrace.Unity.Services
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	internal class BacktraceDatabaseFileContext : IBacktraceDatabaseFileContext
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000DB RID: 219 RVA: 0x000024D4 File Offset: 0x000006D4
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002E")]
		public int ScreenshotQuality
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x743280", Offset = "0x741880", VA = "0x180743280", Slot = "4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x7432A0", Offset = "0x7418A0", VA = "0x1807432A0", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000DD RID: 221 RVA: 0x000024EC File Offset: 0x000006EC
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002F")]
		public int ScreenshotMaxHeight
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x743360", Offset = "0x741960", VA = "0x180743360", Slot = "6")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x743380", Offset = "0x741980", VA = "0x180743380", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x743400", Offset = "0x741A00", VA = "0x180743400")]
		public BacktraceDatabaseFileContext(BacktraceDatabaseSettings settings)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x7437C0", Offset = "0x741DC0", VA = "0x1807437C0", Slot = "9")]
		public IEnumerable<FileInfo> GetAll()
		{
			return null;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x7437E0", Offset = "0x741DE0", VA = "0x1807437E0", Slot = "8")]
		public IEnumerable<FileInfo> GetRecords()
		{
			return null;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x743A30", Offset = "0x742030", VA = "0x180743A30", Slot = "11")]
		public void RemoveOrphaned(IEnumerable<BacktraceDatabaseRecord> existingRecords)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x743F80", Offset = "0x742580", VA = "0x180743F80", Slot = "10")]
		public bool ValidFileConsistency()
		{
			return default(bool);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x7440D0", Offset = "0x7426D0", VA = "0x1807440D0", Slot = "12")]
		public void Clear()
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x744140", Offset = "0x742740", VA = "0x180744140", Slot = "13")]
		public void Delete(BacktraceDatabaseRecord record)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000251C File Offset: 0x0000071C
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x744360", Offset = "0x742960", VA = "0x180744360")]
		private bool IsDatabaseDependency(string path)
		{
			return default(bool);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x7443F0", Offset = "0x7429F0", VA = "0x1807443F0")]
		private void Delete(string path)
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x7445A0", Offset = "0x742BA0", VA = "0x1807445A0", Slot = "14")]
		public IEnumerable<string> GenerateRecordAttachments(BacktraceData data)
		{
			return null;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x7445C0", Offset = "0x742BC0", VA = "0x1807445C0", Slot = "15")]
		public bool Save(BacktraceDatabaseRecord record)
		{
			return default(bool);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x744BE0", Offset = "0x7431E0", VA = "0x180744BE0")]
		private int Save(string json, string destPath)
		{
			return 0;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002564 File Offset: 0x00000764
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x744D90", Offset = "0x743390", VA = "0x180744D90", Slot = "16")]
		public bool IsValidRecord(BacktraceDatabaseRecord record)
		{
			return default(bool);
		}

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x10")]
		private string[] _possibleDatabaseExtension;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x18")]
		private readonly long _maxDatabaseSize;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x20")]
		private readonly uint _maxRecordNumber;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x28")]
		private readonly DirectoryInfo _databaseDirectoryInfo;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		private const string RecordFilterRegex = "*-record.json";

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x30")]
		internal readonly BacktraceDatabaseAttachmentManager _attachmentManager;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x38")]
		private readonly string _path;
	}
}
