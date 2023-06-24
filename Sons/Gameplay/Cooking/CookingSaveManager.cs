using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Save;

namespace Sons.Gameplay.Cooking
{
	// Token: 0x02000879 RID: 2169
	[Token(Token = "0x2000879")]
	public class CookingSaveManager : SingletonBehaviour<CookingSaveManager>, ISaveGameSerializer<CookingSaveManager.CookingManagerSaveData>
	{
		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06003DD3 RID: 15827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700080C")]
		private string SerializedName
		{
			[Token(Token = "0x6003DD3")]
			[Address(RVA = "0x35C64C0", Offset = "0x35C4AC0", VA = "0x1835C64C0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06003DD4 RID: 15828 RVA: 0x00012E28 File Offset: 0x00011028
		[Token(Token = "0x1700080D")]
		private bool UniqueFile
		{
			[Token(Token = "0x6003DD4")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06003DD5 RID: 15829 RVA: 0x00012E40 File Offset: 0x00011040
		[Token(Token = "0x1700080E")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6003DD5")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06003DD6 RID: 15830 RVA: 0x00012E58 File Offset: 0x00011058
		[Token(Token = "0x1700080F")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6003DD6")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003DD7 RID: 15831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DD7")]
		[Address(RVA = "0x35C64F0", Offset = "0x35C4AF0", VA = "0x1835C64F0")]
		private void Start()
		{
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DD8")]
		[Address(RVA = "0x35C6620", Offset = "0x35C4C20", VA = "0x1835C6620", Slot = "9")]
		protected override void PostOnDestroy()
		{
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DD9")]
		[Address(RVA = "0x35C66D0", Offset = "0x35C4CD0", VA = "0x1835C66D0")]
		private void BeforeLoadCleanUp()
		{
		}

		// Token: 0x06003DDA RID: 15834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DDA")]
		[Address(RVA = "0x35C6760", Offset = "0x35C4D60", VA = "0x1835C6760")]
		public static void Register(CookingSurface cookingSurface)
		{
		}

		// Token: 0x06003DDB RID: 15835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DDB")]
		[Address(RVA = "0x35C6820", Offset = "0x35C4E20", VA = "0x1835C6820")]
		public static void Unregister(CookingSurface cookingSurface)
		{
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DDC")]
		[Address(RVA = "0x35C68A0", Offset = "0x35C4EA0", VA = "0x1835C68A0", Slot = "11")]
		private CookingSaveManager.CookingManagerSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DDD")]
		[Address(RVA = "0x35C6C60", Offset = "0x35C5260", VA = "0x1835C6C60", Slot = "12")]
		private void OnDeserialize(CookingSaveManager.CookingManagerSaveData data)
		{
		}

		// Token: 0x06003DDE RID: 15838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DDE")]
		[Address(RVA = "0x35C6DB0", Offset = "0x35C53B0", VA = "0x1835C6DB0")]
		public CookingSaveManager()
		{
		}

		// Token: 0x0400341D RID: 13341
		[Token(Token = "0x400341D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<CookingSurface> _cookingSurfaces;

		// Token: 0x0200087A RID: 2170
		[Token(Token = "0x200087A")]
		[Serializable]
		public class CookingManagerSaveData
		{
			// Token: 0x06003DE0 RID: 15840 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003DE0")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public CookingManagerSaveData()
			{
			}

			// Token: 0x0400341E RID: 13342
			[Token(Token = "0x400341E")]
			[FieldOffset(Offset = "0x10")]
			public List<CookingSurface.CookingPotData> _cookingPotData;
		}
	}
}
