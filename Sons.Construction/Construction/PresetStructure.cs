using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Gameplay;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000202 RID: 514
	[Token(Token = "0x2000202")]
	[AddComponentMenu("Sons/Construction/PresetStructure")]
	public class PresetStructure : Structure, IItemContentChangedReceiver, IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000397")]
		public static Counter Counter
		{
			[Token(Token = "0x6000F6C")]
			[Address(RVA = "0x2EFD960", Offset = "0x2EFBF60", VA = "0x182EFD960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000F6D RID: 3949 RVA: 0x00009644 File Offset: 0x00007844
		[Token(Token = "0x17000398")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000F6D")]
			[Address(RVA = "0x22F5170", Offset = "0x22F3770", VA = "0x1822F5170", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x0000965C File Offset: 0x0000785C
		[Token(Token = "0x17000399")]
		public override int LinkedStructureCount
		{
			[Token(Token = "0x6000F6E")]
			[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000F6F RID: 3951 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700039A")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x6000F6F")]
			[Address(RVA = "0x2EFD9B0", Offset = "0x2EFBFB0", VA = "0x182EFD9B0", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000F70 RID: 3952 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700039B")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x6000F70")]
			[Address(RVA = "0x2EFDA00", Offset = "0x2EFC000", VA = "0x182EFDA00", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000F71 RID: 3953 RVA: 0x00009674 File Offset: 0x00007874
		// (set) Token: 0x06000F72 RID: 3954 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700039C")]
		public bool HasContent
		{
			[Token(Token = "0x6000F71")]
			[Address(RVA = "0x674880", Offset = "0x672E80", VA = "0x180674880")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000F72")]
			[Address(RVA = "0x674890", Offset = "0x672E90", VA = "0x180674890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F73")]
		[Address(RVA = "0x2EFDA50", Offset = "0x2EFC050", VA = "0x182EFDA50", Slot = "57")]
		public override void SetInstanceID(uint id)
		{
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x0000968C File Offset: 0x0000788C
		[Token(Token = "0x6000F74")]
		[Address(RVA = "0x2E8F6E0", Offset = "0x2E8DCE0", VA = "0x182E8F6E0", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x000096A4 File Offset: 0x000078A4
		[Token(Token = "0x6000F75")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "69")]
		public override bool IsCompleted()
		{
			return default(bool);
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000F76")]
		[Address(RVA = "0x2EFDB40", Offset = "0x2EFC140", VA = "0x182EFDB40", Slot = "78")]
		public override StructureElement AddElement(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F77")]
		[Address(RVA = "0x2EFDFE0", Offset = "0x2EFC5E0", VA = "0x182EFDFE0", Slot = "105")]
		public void ContentChanged()
		{
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x000096BC File Offset: 0x000078BC
		[Token(Token = "0x6000F78")]
		[Address(RVA = "0x268EE60", Offset = "0x268D460", VA = "0x18268EE60", Slot = "102")]
		public override float GetStructuralResistanceFactor(int maxDepth)
		{
			return 0f;
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x000096D4 File Offset: 0x000078D4
		[Token(Token = "0x6000F79")]
		[Address(RVA = "0x2EFE300", Offset = "0x2EFC900", VA = "0x182EFE300", Slot = "103")]
		public override float GetAdditionalElementHP()
		{
			return 0f;
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F7A")]
		[Address(RVA = "0x2EFE330", Offset = "0x2EFC930", VA = "0x182EFE330")]
		public PresetStructure()
		{
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000F7C")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000F7D")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000F7E")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x000096EC File Offset: 0x000078EC
		[Token(Token = "0x6000F7F")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x0400083B RID: 2107
		[Token(Token = "0x400083B")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x0400083C RID: 2108
		[Token(Token = "0x400083C")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Directions[] SupportedByDirs;
	}
}
