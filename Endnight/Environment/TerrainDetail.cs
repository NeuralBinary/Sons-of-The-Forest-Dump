using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Endnight.Environment
{
	// Token: 0x020000BB RID: 187
	[Token(Token = "0x20000BB")]
	[Serializable]
	public class TerrainDetail
	{
		// Token: 0x0600045C RID: 1116 RVA: 0x00004560 File Offset: 0x00002760
		[Token(Token = "0x600045C")]
		[Address(RVA = "0xAA8060", Offset = "0xAA6660", VA = "0x180AA8060", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void RefreshId(int index)
		{
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600045E")]
		[Address(RVA = "0xAA81F0", Offset = "0xAA67F0", VA = "0x180AA81F0")]
		public byte[] GetUniqueId()
		{
			return null;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600045F")]
		[Address(RVA = "0xAA8220", Offset = "0xAA6820", VA = "0x180AA8220")]
		public static byte[] CalculateUniqueId(Vector3 position, string detailId)
		{
			return null;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000460")]
		[Address(RVA = "0xAA85B0", Offset = "0xAA6BB0", VA = "0x180AA85B0")]
		public static string ByteArrayToString(byte[] ba)
		{
			return null;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000461")]
		[Address(RVA = "0xAA8730", Offset = "0xAA6D30", VA = "0x180AA8730")]
		private static string CalculateMd5Hash(byte[] inputBytes)
		{
			return null;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
		public void SetId(int id)
		{
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000463")]
		[Address(RVA = "0xAA89D0", Offset = "0xAA6FD0", VA = "0x180AA89D0")]
		public TerrainDetail(Vector3 position, Quaternion rotation, Vector3 scale, string detailId, UnityEngine.Object target, string worldGroupId, string hLodId)
		{
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00004578 File Offset: 0x00002778
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x9DE860", Offset = "0x9DCE60", VA = "0x1809DE860")]
		public static int GetSizeBytes()
		{
			return 0;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700003D")]
		public string DetailId
		{
			[Token(Token = "0x6000465")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00004590 File Offset: 0x00002790
		[Token(Token = "0x1700003E")]
		public Vector3 Position
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0xAA8B50", Offset = "0xAA7150", VA = "0x180AA8B50")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x000045A8 File Offset: 0x000027A8
		[Token(Token = "0x1700003F")]
		public Quaternion Rotation
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0xAA8B70", Offset = "0xAA7170", VA = "0x180AA8B70")]
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x000045C0 File Offset: 0x000027C0
		[Token(Token = "0x17000040")]
		public Vector3 Scale
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x62AC70", Offset = "0x629270", VA = "0x18062AC70")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x000045D8 File Offset: 0x000027D8
		[Token(Token = "0x17000041")]
		public int Id
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000042")]
		public UnityEngine.Object Target
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000043")]
		public string WorldGroupId
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000044")]
		public string HLodId
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int _id;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Vector3 _position;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Quaternion _rotation;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector3 _scale;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[FormerlySerializedAs("_sourceId")]
		private string _detailId;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UnityEngine.Object _target;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _worldGroupId;

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _hLodId;
	}
}
