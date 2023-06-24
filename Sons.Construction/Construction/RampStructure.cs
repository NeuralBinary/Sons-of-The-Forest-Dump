using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000220 RID: 544
	[Token(Token = "0x2000220")]
	[AddComponentMenu("Sons/Construction/RampStructure")]
	public class RampStructure : FloorStructure, IWallSupport, IStructure, IMonoBehaviour, ISuperStructureNode, ISolarPanelSupport
	{
		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x0600103B RID: 4155 RVA: 0x00009D94 File Offset: 0x00007F94
		[Token(Token = "0x170003C4")]
		public override ushort TypeID
		{
			[Token(Token = "0x600103B")]
			[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x00009DAC File Offset: 0x00007FAC
		[Token(Token = "0x170003C5")]
		public override int LinkedStructureCount
		{
			[Token(Token = "0x600103C")]
			[Address(RVA = "0x6A2B30", Offset = "0x6A1130", VA = "0x1806A2B30", Slot = "50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003C6")]
		public new IRampSupport BackSupport
		{
			[Token(Token = "0x600103D")]
			[Address(RVA = "0x2F10090", Offset = "0x2F0E690", VA = "0x182F10090")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003C7")]
		public new IRampSupport ForwardSupport
		{
			[Token(Token = "0x600103E")]
			[Address(RVA = "0x2F100D0", Offset = "0x2F0E6D0", VA = "0x182F100D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003C8")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x600103F")]
			[Address(RVA = "0x2F10110", Offset = "0x2F0E710", VA = "0x182F10110", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003C9")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x6001040")]
			[Address(RVA = "0x2F10160", Offset = "0x2F0E760", VA = "0x182F10160", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x00009DC4 File Offset: 0x00007FC4
		[Token(Token = "0x170003CA")]
		protected override bool UseCeilingRounding
		{
			[Token(Token = "0x6001041")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "123")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003CB")]
		public new static Counter Counter
		{
			[Token(Token = "0x6001042")]
			[Address(RVA = "0x2F101B0", Offset = "0x2F0E7B0", VA = "0x182F101B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x00009DDC File Offset: 0x00007FDC
		[Token(Token = "0x6001043")]
		[Address(RVA = "0x2F10200", Offset = "0x2F0E800", VA = "0x182F10200", Slot = "74")]
		public override Vector3 CalcElementPosition(StructureElement elementPrefab, int elementIndex)
		{
			return default(Vector3);
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x00009DF4 File Offset: 0x00007FF4
		[Token(Token = "0x6001044")]
		[Address(RVA = "0x2F103D0", Offset = "0x2F0E9D0", VA = "0x182F103D0", Slot = "76")]
		public override Quaternion CalcNextElementRotation(StructureElement elementPrefab)
		{
			return default(Quaternion);
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001045")]
		[Address(RVA = "0x2F10590", Offset = "0x2F0EB90", VA = "0x182F10590", Slot = "63")]
		public override void OnElementsChanged()
		{
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001046")]
		[Address(RVA = "0x2F10590", Offset = "0x2F0EB90", VA = "0x182F10590", Slot = "59")]
		public override void OnPostLoad()
		{
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001047")]
		[Address(RVA = "0x2F105C0", Offset = "0x2F0EBC0", VA = "0x182F105C0", Slot = "61")]
		public override void OnDestroyingStructure()
		{
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x00009E0C File Offset: 0x0000800C
		[Token(Token = "0x6001048")]
		[Address(RVA = "0x2F10610", Offset = "0x2F0EC10", VA = "0x182F10610", Slot = "127")]
		protected override float ExtraNavCutHeight()
		{
			return 0f;
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001049")]
		[Address(RVA = "0x2F10620", Offset = "0x2F0EC20", VA = "0x182F10620")]
		private void RefreshSuperStructure()
		{
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x00009E24 File Offset: 0x00008024
		[Token(Token = "0x600104A")]
		[Address(RVA = "0x2F10700", Offset = "0x2F0ED00", VA = "0x182F10700")]
		public Vector3 CalcRampPositions(out Vector3 highCenterPos, out Vector3 lowCenterPos)
		{
			return default(Vector3);
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x00009E3C File Offset: 0x0000803C
		[Token(Token = "0x600104B")]
		[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "115")]
		private Directions GetSolarPanelDir()
		{
			return Directions.LeafStructureSupport;
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600104C")]
		[Address(RVA = "0x2F10A80", Offset = "0x2F0F080", VA = "0x182F10A80", Slot = "117")]
		private void SetSolarPanel(SolarPanelStructure solarPanel)
		{
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00009E54 File Offset: 0x00008054
		[Token(Token = "0x600104D")]
		[Address(RVA = "0x2F10AA0", Offset = "0x2F0F0A0", VA = "0x182F10AA0", Slot = "118")]
		private bool TryGetSolarPanel(out SolarPanelStructure solarPanel)
		{
			return default(bool);
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00009E6C File Offset: 0x0000806C
		[Token(Token = "0x600104E")]
		[Address(RVA = "0x2F10B40", Offset = "0x2F0F140", VA = "0x182F10B40", Slot = "119")]
		private Vector3 GetSolarPanelSnapPos()
		{
			return default(Vector3);
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00009E84 File Offset: 0x00008084
		[Token(Token = "0x600104F")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "107")]
		private bool CanHostNewWall()
		{
			return default(bool);
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001050")]
		[Address(RVA = "0x2F10CE0", Offset = "0x2F0F2E0", VA = "0x182F10CE0")]
		public RampStructure()
		{
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001052")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001053")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001054")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00009E9C File Offset: 0x0000809C
		[Token(Token = "0x6001055")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x04000890 RID: 2192
		[Token(Token = "0x4000890")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x04000891 RID: 2193
		[Token(Token = "0x4000891")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Directions[] SupportedByDirs;

		// Token: 0x02000221 RID: 545
		[Token(Token = "0x2000221")]
		public new static class Utils
		{
			// Token: 0x06001056 RID: 4182 RVA: 0x00009EB4 File Offset: 0x000080B4
			[Token(Token = "0x6001056")]
			[Address(RVA = "0x2F10F30", Offset = "0x2F0F530", VA = "0x182F10F30")]
			internal static Vector3 CalcRampOnSupportAxis(IRampSupport support)
			{
				return default(Vector3);
			}

			// Token: 0x06001057 RID: 4183 RVA: 0x00009ECC File Offset: 0x000080CC
			[Token(Token = "0x6001057")]
			[Address(RVA = "0x2F11000", Offset = "0x2F0F600", VA = "0x182F11000")]
			public static Vector3 CalcRampPosFromSupports(IRampSupport support1, IRampSupport support2, StructureElement floorElementPrefab)
			{
				return default(Vector3);
			}
		}
	}
}
