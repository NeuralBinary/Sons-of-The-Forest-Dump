using System;
using System.Runtime.CompilerServices;
using Construction.Utils;
using Il2CppDummyDll;
using Sons.ConstructionBoltToken;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000FE RID: 254
	[Token(Token = "0x20000FE")]
	[AddComponentMenu("Sons/Construction/StructureElement")]
	public class StructureElement : MonoBehaviour, IElementIdentifier, ISyncableElement, IMonoBehaviour, ISolidGroundProvider
	{
		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700023B")]
		public ElementProfile Profile
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x00005114 File Offset: 0x00003314
		[Token(Token = "0x1700023C")]
		public Vector3 Size
		{
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x781510", Offset = "0x77FB10", VA = "0x180781510")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x0000512C File Offset: 0x0000332C
		[Token(Token = "0x1700023D")]
		public float ExtremityToSnapPositionOffset
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0x2E39050", Offset = "0x2E37650", VA = "0x182E39050")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x00005144 File Offset: 0x00003344
		// (set) Token: 0x06000718 RID: 1816 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700023E")]
		public bool PendingDestroy
		{
			[Token(Token = "0x6000717")]
			[Address(RVA = "0x2084CB0", Offset = "0x20832B0", VA = "0x182084CB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x2084CC0", Offset = "0x20832C0", VA = "0x182084CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x0000515C File Offset: 0x0000335C
		[Token(Token = "0x1700023F")]
		public ushort ProfileID
		{
			[Token(Token = "0x6000719")]
			[Address(RVA = "0x2E39070", Offset = "0x2E37670", VA = "0x182E39070", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00005174 File Offset: 0x00003374
		[Token(Token = "0x17000240")]
		private bool IsSolidGround
		{
			[Token(Token = "0x600071A")]
			[Address(RVA = "0x2E39090", Offset = "0x2E37690", VA = "0x182E39090", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x781530", Offset = "0x77FB30", VA = "0x180781530")]
		public void SetSize(Vector3 size)
		{
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0000518C File Offset: 0x0000338C
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x2E390B0", Offset = "0x2E376B0", VA = "0x182E390B0")]
		public Bounds CalcBounds()
		{
			return default(Bounds);
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x000051A4 File Offset: 0x000033A4
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x2E39330", Offset = "0x2E37930", VA = "0x182E39330")]
		public float CalcTopHeight()
		{
			return 0f;
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x000051BC File Offset: 0x000033BC
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x2E39490", Offset = "0x2E37A90", VA = "0x182E39490")]
		public float CalcBottomHeight()
		{
			return 0f;
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x2E395F0", Offset = "0x2E37BF0", VA = "0x182E395F0")]
		public void Destroy()
		{
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public StructureElement()
		{
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "6")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "7")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x000051D4 File Offset: 0x000033D4
		[Token(Token = "0x6000723")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x04000522 RID: 1314
		[Token(Token = "0x4000522")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ElementProfile _profile;

		// Token: 0x04000523 RID: 1315
		[Token(Token = "0x4000523")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Vector3 _size;
	}
}
