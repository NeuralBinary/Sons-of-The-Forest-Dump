using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons;
using Sons.TerrainDetail;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	[Serializable]
	public class TargetInfo
	{
		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x000034DC File Offset: 0x000016DC
		[Token(Token = "0x170000FA")]
		public float HitDistance
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0xA308D0", Offset = "0xA2EED0", VA = "0x180A308D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x000034F4 File Offset: 0x000016F4
		[Token(Token = "0x170000FB")]
		public Vector3 HitPoint
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0xAA8B50", Offset = "0xAA7150", VA = "0x180AA8B50")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x0000350C File Offset: 0x0000170C
		[Token(Token = "0x170000FC")]
		public Vector3 HitNormal
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x29A0830", Offset = "0x299EE30", VA = "0x1829A0830")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00003524 File Offset: 0x00001724
		[Token(Token = "0x170000FD")]
		public Vector3 LookAtPoint
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x28D1490", Offset = "0x28CFA90", VA = "0x1828D1490")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x0000353C File Offset: 0x0000173C
		[Token(Token = "0x170000FE")]
		public int TransformIndex
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x6E6C40", Offset = "0x6E5240", VA = "0x1806E6C40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000FF")]
		public Transform Transform
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000100")]
		public IElementIdentifier ElementIdentifier
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060002CA RID: 714 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000101")]
		public StructureElement Instance
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000102")]
		public WorldLocatorId WorldLocatorId
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00003554 File Offset: 0x00001754
		[Token(Token = "0x17000103")]
		public bool IsTerrain
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x2D7CC00", Offset = "0x2D7B200", VA = "0x182D7CC00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0000356C File Offset: 0x0000176C
		[Token(Token = "0x17000104")]
		public bool IsTree
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x2D7CD00", Offset = "0x2D7B300", VA = "0x182D7CD00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060002CE RID: 718 RVA: 0x00003584 File Offset: 0x00001784
		[Token(Token = "0x17000105")]
		public bool IsSapling
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x2D7CDE0", Offset = "0x2D7B3E0", VA = "0x182D7CDE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0000359C File Offset: 0x0000179C
		[Token(Token = "0x17000106")]
		public bool IsValidTerrainRock
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x2D7CEC0", Offset = "0x2D7B4C0", VA = "0x182D7CEC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x000035B4 File Offset: 0x000017B4
		[Token(Token = "0x17000107")]
		public bool IsValidCaveGround
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x2D7D120", Offset = "0x2D7B720", VA = "0x182D7D120")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x000035CC File Offset: 0x000017CC
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000108")]
		public bool IsInvalid
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x9ABDB0", Offset = "0x9AA3B0", VA = "0x1809ABDB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x2586730", Offset = "0x2584D30", VA = "0x182586730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000109")]
		public TargetInfo.Structures Targeted
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x8DD0A0", Offset = "0x8DB6A0", VA = "0x1808DD0A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700010A")]
		public TargetInfo.Structures Editing
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700010B")]
		public TargetInfo.Structures Support1
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x750FA0", Offset = "0x74F5A0", VA = "0x180750FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700010C")]
		public TargetInfo.Structures Support2
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x737420", Offset = "0x735A20", VA = "0x180737420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700010D")]
		public TargetInfo.Structures Support3
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x751010", Offset = "0x74F610", VA = "0x180751010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700010E")]
		public TargetInfo.Structures Support4
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0xA03D90", Offset = "0xA02390", VA = "0x180A03D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x000035E4 File Offset: 0x000017E4
		[Token(Token = "0x1700010F")]
		public Vector3 PlaceAxis
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x2D7D380", Offset = "0x2D7B980", VA = "0x182D7D380")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060002DA RID: 730 RVA: 0x000035FC File Offset: 0x000017FC
		[Token(Token = "0x17000110")]
		public Vector3 PlacePosition
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x26FA7B0", Offset = "0x26F8DB0", VA = "0x1826FA7B0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060002DB RID: 731 RVA: 0x00003614 File Offset: 0x00001814
		[Token(Token = "0x17000111")]
		public Vector3 CutPosition
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x26FA7B0", Offset = "0x26F8DB0", VA = "0x1826FA7B0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x2D7D3A0", Offset = "0x2D7B9A0", VA = "0x182D7D3A0")]
		public void Init(RaycastHit hit)
		{
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x2D7D780", Offset = "0x2D7BD80", VA = "0x182D7D780")]
		public void Init(Collider col, Vector3 lookPos)
		{
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x2D7DAF0", Offset = "0x2D7C0F0", VA = "0x182D7DAF0")]
		public void InitFrom(TargetInfo otherTarget)
		{
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x2D7DE50", Offset = "0x2D7C450", VA = "0x182D7DE50")]
		public void CalcHitDistance()
		{
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x2D7DFC0", Offset = "0x2D7C5C0", VA = "0x182D7DFC0")]
		public void CalcLookAtPoint()
		{
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x2D7E130", Offset = "0x2D7C730", VA = "0x182D7E130")]
		public void CalcHitPoint()
		{
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xA308E0", Offset = "0xA2EEE0", VA = "0x180A308E0")]
		public void SetHitDistance(float hitDistance)
		{
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x200AC50", Offset = "0x2009250", VA = "0x18200AC50")]
		public void SetLookAtPoint(Vector3 lookatPoint)
		{
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x290B4E0", Offset = "0x2909AE0", VA = "0x18290B4E0")]
		public void SetHitPoint(Vector3 hitPoint)
		{
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x29A0850", Offset = "0x299EE50", VA = "0x1829A0850")]
		public void SetHitNormal(Vector3 hitNormal)
		{
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x2D7E210", Offset = "0x2D7C810", VA = "0x182D7E210")]
		public void SetTargetTransform(Transform targetTr)
		{
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x2D7E580", Offset = "0x2D7CB80", VA = "0x182D7E580")]
		public void SetPlaceAxis(Vector3 placeAxis)
		{
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x26FA7D0", Offset = "0x26F8DD0", VA = "0x1826FA7D0")]
		public void SetPlacePosition(Vector3 placePosition)
		{
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x26FA7D0", Offset = "0x26F8DD0", VA = "0x1826FA7D0")]
		public void SetCutPosition(Vector3 cutPosition)
		{
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x2586730", Offset = "0x2584D30", VA = "0x182586730")]
		public void SetIsInvalid(bool isInvalid)
		{
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x6F1D10", Offset = "0x6F0310", VA = "0x1806F1D10")]
		public void SetWorldLocatorId(WorldLocatorId worldLocatorId)
		{
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x2D7E590", Offset = "0x2D7CB90", VA = "0x182D7E590")]
		public void RefreshPlaceAxisFromLookPos()
		{
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x2D7E690", Offset = "0x2D7CC90", VA = "0x182D7E690")]
		public void Reset()
		{
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x2D7EA50", Offset = "0x2D7D050", VA = "0x182D7EA50")]
		public void Dispose()
		{
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x2D7EAC0", Offset = "0x2D7D0C0", VA = "0x182D7EAC0")]
		public TargetInfo.Structures GetSupport(int num)
		{
			return null;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x2D7EB00", Offset = "0x2D7D100", VA = "0x182D7EB00")]
		public TargetInfo.Structures GetSupport(Directions dir)
		{
			return null;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x2D7EB40", Offset = "0x2D7D140", VA = "0x182D7EB40")]
		public TargetInfo()
		{
		}

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x10")]
		private float _hitDistance;

		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 _hitPoint;

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 _hitNormal;

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 _lookAtPoint;

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x38")]
		private int _transformIndex;

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x40")]
		private Transform _transform;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x48")]
		private IElementIdentifier _elementIdentifier;

		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x50")]
		private StructureElement _instance;

		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 _placeAxis;

		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 _calculatedPosition;

		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x70")]
		private WorldLocatorId _worldLocatorId;

		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x78")]
		private ObjectCategory _objectCategory;

		// Token: 0x0200006F RID: 111
		[Token(Token = "0x200006F")]
		[Serializable]
		public class Structures
		{
			// Token: 0x17000112 RID: 274
			// (get) Token: 0x060002F2 RID: 754 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x060002F3 RID: 755 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000112")]
			public Structure Structure
			{
				[Token(Token = "0x60002F2")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60002F3")]
				[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x060002F4 RID: 756 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000113")]
			public WallStructure Wall
			{
				[Token(Token = "0x60002F4")]
				[Address(RVA = "0x2D7EDD0", Offset = "0x2D7D3D0", VA = "0x182D7EDD0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x060002F5 RID: 757 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000114")]
			public RockWallStructure RockWall
			{
				[Token(Token = "0x60002F5")]
				[Address(RVA = "0x2D7EE50", Offset = "0x2D7D450", VA = "0x182D7EE50")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x060002F6 RID: 758 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000115")]
			public BeamStructure Beam
			{
				[Token(Token = "0x60002F6")]
				[Address(RVA = "0x2D7EED0", Offset = "0x2D7D4D0", VA = "0x182D7EED0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x060002F7 RID: 759 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000116")]
			public RockBeamStructure RockBeam
			{
				[Token(Token = "0x60002F7")]
				[Address(RVA = "0x2D7EF50", Offset = "0x2D7D550", VA = "0x182D7EF50")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x060002F8 RID: 760 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000117")]
			public FloorStructure Floor
			{
				[Token(Token = "0x60002F8")]
				[Address(RVA = "0x2D7EFD0", Offset = "0x2D7D5D0", VA = "0x182D7EFD0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x060002F9 RID: 761 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000118")]
			public RampStructure Ramp
			{
				[Token(Token = "0x60002F9")]
				[Address(RVA = "0x2D7F050", Offset = "0x2D7D650", VA = "0x182D7F050")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x060002FA RID: 762 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000119")]
			public WalkwayStructure Walkway
			{
				[Token(Token = "0x60002FA")]
				[Address(RVA = "0x2D7F0D0", Offset = "0x2D7D6D0", VA = "0x182D7F0D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x060002FB RID: 763 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700011A")]
			public PilarStructure Pilar
			{
				[Token(Token = "0x60002FB")]
				[Address(RVA = "0x2D7F150", Offset = "0x2D7D750", VA = "0x182D7F150")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x060002FC RID: 764 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700011B")]
			public FakePilarStructure FakePilar
			{
				[Token(Token = "0x60002FC")]
				[Address(RVA = "0x2D7F1D0", Offset = "0x2D7D7D0", VA = "0x182D7F1D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x060002FD RID: 765 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700011C")]
			public ApexStructure Apex
			{
				[Token(Token = "0x60002FD")]
				[Address(RVA = "0x2D7F250", Offset = "0x2D7D850", VA = "0x182D7F250")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x060002FE RID: 766 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700011D")]
			public DefensiveWallStructure DefensiveWall
			{
				[Token(Token = "0x60002FE")]
				[Address(RVA = "0x2D7F2D0", Offset = "0x2D7D8D0", VA = "0x182D7F2D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x060002FF RID: 767 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700011E")]
			public DefensiveWallGateStructure DefensiveWallGate
			{
				[Token(Token = "0x60002FF")]
				[Address(RVA = "0x2D7F350", Offset = "0x2D7D950", VA = "0x182D7F350")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x06000300 RID: 768 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700011F")]
			public TarpStructure Tarp
			{
				[Token(Token = "0x6000300")]
				[Address(RVA = "0x2D7F3D0", Offset = "0x2D7D9D0", VA = "0x182D7F3D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x06000301 RID: 769 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000120")]
			public PresetTarpStructure PresetTarp
			{
				[Token(Token = "0x6000301")]
				[Address(RVA = "0x2D7F450", Offset = "0x2D7DA50", VA = "0x182D7F450")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x06000302 RID: 770 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000121")]
			public PresetStructure Preset
			{
				[Token(Token = "0x6000302")]
				[Address(RVA = "0x2D7F4D0", Offset = "0x2D7DAD0", VA = "0x182D7F4D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x06000303 RID: 771 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000122")]
			public CompoundStructure Compound
			{
				[Token(Token = "0x6000303")]
				[Address(RVA = "0x2D7F550", Offset = "0x2D7DB50", VA = "0x182D7F550")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x06000304 RID: 772 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000123")]
			public HalfStairsStructure HalfStairs
			{
				[Token(Token = "0x6000304")]
				[Address(RVA = "0x2D7F5D0", Offset = "0x2D7DBD0", VA = "0x182D7F5D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x06000305 RID: 773 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000124")]
			public DoorStructure Door
			{
				[Token(Token = "0x6000305")]
				[Address(RVA = "0x2D7F650", Offset = "0x2D7DC50", VA = "0x182D7F650")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x06000306 RID: 774 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000125")]
			public ShutterStructure Shutter
			{
				[Token(Token = "0x6000306")]
				[Address(RVA = "0x2D7F6D0", Offset = "0x2D7DCD0", VA = "0x182D7F6D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x06000307 RID: 775 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000126")]
			public DecorationStructure Decoration
			{
				[Token(Token = "0x6000307")]
				[Address(RVA = "0x2D7F750", Offset = "0x2D7DD50", VA = "0x182D7F750")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x06000308 RID: 776 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000127")]
			public RaftStructure Raft
			{
				[Token(Token = "0x6000308")]
				[Address(RVA = "0x2D7F7D0", Offset = "0x2D7DDD0", VA = "0x182D7F7D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x06000309 RID: 777 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000128")]
			public LadderStructure Ladder
			{
				[Token(Token = "0x6000309")]
				[Address(RVA = "0x2D7F850", Offset = "0x2D7DE50", VA = "0x182D7F850")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x0600030A RID: 778 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000129")]
			public StrutStructure Strut
			{
				[Token(Token = "0x600030A")]
				[Address(RVA = "0x2D7F8D0", Offset = "0x2D7DED0", VA = "0x182D7F8D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x0600030B RID: 779 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700012A")]
			public FenceStructure Fence
			{
				[Token(Token = "0x600030B")]
				[Address(RVA = "0x2D7F950", Offset = "0x2D7DF50", VA = "0x182D7F950")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x0600030C RID: 780 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700012B")]
			public FencePostStructure FencePost
			{
				[Token(Token = "0x600030C")]
				[Address(RVA = "0x2D7F9D0", Offset = "0x2D7DFD0", VA = "0x182D7F9D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x0600030D RID: 781 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700012C")]
			public TreeStructure TreeStructure
			{
				[Token(Token = "0x600030D")]
				[Address(RVA = "0x2D7FA50", Offset = "0x2D7E050", VA = "0x182D7FA50")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x0600030E RID: 782 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700012D")]
			public EffigyStructure Effigy
			{
				[Token(Token = "0x600030E")]
				[Address(RVA = "0x2D7FAD0", Offset = "0x2D7E0D0", VA = "0x182D7FAD0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x0600030F RID: 783 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700012E")]
			public FurnitureStructure Furniture
			{
				[Token(Token = "0x600030F")]
				[Address(RVA = "0x2D7FB50", Offset = "0x2D7E150", VA = "0x182D7FB50")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x06000310 RID: 784 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700012F")]
			public FireStructure Fire
			{
				[Token(Token = "0x6000310")]
				[Address(RVA = "0x2D7FBD0", Offset = "0x2D7E1D0", VA = "0x182D7FBD0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x06000311 RID: 785 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000130")]
			public BridgeRopeStructure BridgeRope
			{
				[Token(Token = "0x6000311")]
				[Address(RVA = "0x2D7FC50", Offset = "0x2D7E250", VA = "0x182D7FC50")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x06000312 RID: 786 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000131")]
			public BridgeFloorStructure BridgeFloor
			{
				[Token(Token = "0x6000312")]
				[Address(RVA = "0x2D7FCD0", Offset = "0x2D7E2D0", VA = "0x182D7FCD0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x06000313 RID: 787 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000132")]
			public StackStructure Stack
			{
				[Token(Token = "0x6000313")]
				[Address(RVA = "0x2D7FD50", Offset = "0x2D7E350", VA = "0x182D7FD50")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x06000314 RID: 788 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000133")]
			public SingleStepStructure SingleStep
			{
				[Token(Token = "0x6000314")]
				[Address(RVA = "0x2D7FDD0", Offset = "0x2D7E3D0", VA = "0x182D7FDD0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x06000315 RID: 789 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000134")]
			public ElectricWireStructure ElectricWire
			{
				[Token(Token = "0x6000315")]
				[Address(RVA = "0x2D7FE50", Offset = "0x2D7E450", VA = "0x182D7FE50")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x06000316 RID: 790 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000135")]
			public ElectricDeviceStructure ElectricDevice
			{
				[Token(Token = "0x6000316")]
				[Address(RVA = "0x2D7FED0", Offset = "0x2D7E4D0", VA = "0x182D7FED0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x06000317 RID: 791 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000136")]
			public SolarPanelStructure SolarPanel
			{
				[Token(Token = "0x6000317")]
				[Address(RVA = "0x2D7FF50", Offset = "0x2D7E550", VA = "0x182D7FF50")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x06000318 RID: 792 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000137")]
			public IBreakableStructure BreakableStructure
			{
				[Token(Token = "0x6000318")]
				[Address(RVA = "0x2D7FFD0", Offset = "0x2D7E5D0", VA = "0x182D7FFD0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x06000319 RID: 793 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000138")]
			public IReinforceableStructure ReinforceableStructure
			{
				[Token(Token = "0x6000319")]
				[Address(RVA = "0x2D80010", Offset = "0x2D7E610", VA = "0x182D80010")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x0600031A RID: 794 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000139")]
			public IWallSupport WallSupport
			{
				[Token(Token = "0x600031A")]
				[Address(RVA = "0x2D80050", Offset = "0x2D7E650", VA = "0x182D80050")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x0600031B RID: 795 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700013A")]
			public IFloorSupport FloorSupport
			{
				[Token(Token = "0x600031B")]
				[Address(RVA = "0x2D80090", Offset = "0x2D7E690", VA = "0x182D80090")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x0600031C RID: 796 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700013B")]
			public IRampSupport RampSupport
			{
				[Token(Token = "0x600031C")]
				[Address(RVA = "0x2D800D0", Offset = "0x2D7E6D0", VA = "0x182D800D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x0600031D RID: 797 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700013C")]
			public IBeamSupport BeamSupport
			{
				[Token(Token = "0x600031D")]
				[Address(RVA = "0x2D80110", Offset = "0x2D7E710", VA = "0x182D80110")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x0600031E RID: 798 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700013D")]
			public IApexSupport ApexSupport
			{
				[Token(Token = "0x600031E")]
				[Address(RVA = "0x2D80150", Offset = "0x2D7E750", VA = "0x182D80150")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x0600031F RID: 799 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700013E")]
			public IPilarSupport PilarSupport
			{
				[Token(Token = "0x600031F")]
				[Address(RVA = "0x2D80190", Offset = "0x2D7E790", VA = "0x182D80190")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x06000320 RID: 800 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700013F")]
			public IHalfStairsSupport HalfStairsSupport
			{
				[Token(Token = "0x6000320")]
				[Address(RVA = "0x2D801D0", Offset = "0x2D7E7D0", VA = "0x182D801D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000140 RID: 320
			// (get) Token: 0x06000321 RID: 801 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000140")]
			public IBridgeRopeSupport BridgeRopeSupport
			{
				[Token(Token = "0x6000321")]
				[Address(RVA = "0x2D80210", Offset = "0x2D7E810", VA = "0x182D80210")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000141 RID: 321
			// (get) Token: 0x06000322 RID: 802 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000141")]
			public IClimbRopeSupport ClimbRopeSupport
			{
				[Token(Token = "0x6000322")]
				[Address(RVA = "0x2D80250", Offset = "0x2D7E850", VA = "0x182D80250")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000142 RID: 322
			// (get) Token: 0x06000323 RID: 803 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000142")]
			public ISingleStepSupport SingleStepSupport
			{
				[Token(Token = "0x6000323")]
				[Address(RVA = "0x2D80290", Offset = "0x2D7E890", VA = "0x182D80290")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000143 RID: 323
			// (get) Token: 0x06000324 RID: 804 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000143")]
			public IElectricWireSupport ElectricWireSupport
			{
				[Token(Token = "0x6000324")]
				[Address(RVA = "0x2D802D0", Offset = "0x2D7E8D0", VA = "0x182D802D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x06000325 RID: 805 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000144")]
			public IElectricDeviceSupport ElectricDeviceSupport
			{
				[Token(Token = "0x6000325")]
				[Address(RVA = "0x2D80310", Offset = "0x2D7E910", VA = "0x182D80310")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000145 RID: 325
			// (get) Token: 0x06000326 RID: 806 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000145")]
			public ISolarPanelSupport SolarPanelSupport
			{
				[Token(Token = "0x6000326")]
				[Address(RVA = "0x2D80350", Offset = "0x2D7E950", VA = "0x182D80350")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000146 RID: 326
			// (get) Token: 0x06000327 RID: 807 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000146")]
			public IEffigySupport EffigySupport
			{
				[Token(Token = "0x6000327")]
				[Address(RVA = "0x2D80390", Offset = "0x2D7E990", VA = "0x182D80390")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x06000328 RID: 808 RVA: 0x0000362C File Offset: 0x0000182C
			// (set) Token: 0x06000329 RID: 809 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000147")]
			public Directions Direction
			{
				[Token(Token = "0x6000328")]
				[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
				[CompilerGenerated]
				get
				{
					return Directions.LeafStructureSupport;
				}
				[Token(Token = "0x6000329")]
				[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x0600032A RID: 810 RVA: 0x00003644 File Offset: 0x00001844
			[Token(Token = "0x17000148")]
			public WallDirections WallDirection
			{
				[Token(Token = "0x600032A")]
				[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
				get
				{
					return (WallDirections)0;
				}
			}

			// Token: 0x17000149 RID: 329
			// (get) Token: 0x0600032B RID: 811 RVA: 0x0000365C File Offset: 0x0000185C
			[Token(Token = "0x17000149")]
			public FloorDirections FloorDirection
			{
				[Token(Token = "0x600032B")]
				[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
				get
				{
					return FloorDirections.BackSupport;
				}
			}

			// Token: 0x1700014A RID: 330
			// (get) Token: 0x0600032C RID: 812 RVA: 0x00003674 File Offset: 0x00001874
			[Token(Token = "0x1700014A")]
			public TarpDirections TarpDirection
			{
				[Token(Token = "0x600032C")]
				[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
				get
				{
					return TarpDirections.BackBeam;
				}
			}

			// Token: 0x1700014B RID: 331
			// (get) Token: 0x0600032D RID: 813 RVA: 0x0000368C File Offset: 0x0000188C
			[Token(Token = "0x1700014B")]
			public BeamDirections BeamDirection
			{
				[Token(Token = "0x600032D")]
				[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
				get
				{
					return BeamDirections.BackSupport;
				}
			}

			// Token: 0x0600032E RID: 814 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
			public void Set(int direction)
			{
			}

			// Token: 0x0600032F RID: 815 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
			public void Set(Directions direction)
			{
			}

			// Token: 0x06000330 RID: 816 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
			public void Set(WallDirections direction)
			{
			}

			// Token: 0x06000331 RID: 817 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
			public void Set(FloorDirections direction)
			{
			}

			// Token: 0x06000332 RID: 818 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
			public void Set(TarpDirections direction)
			{
			}

			// Token: 0x06000333 RID: 819 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
			public void Set(BeamDirections direction)
			{
			}

			// Token: 0x06000334 RID: 820 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
			public void Set(PilarDirections direction)
			{
			}

			// Token: 0x06000335 RID: 821 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
			public void Set(RampDirections direction)
			{
			}

			// Token: 0x06000336 RID: 822 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
			public void Set(ElectricWireDirections direction)
			{
			}

			// Token: 0x06000337 RID: 823 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x2D803D0", Offset = "0x2D7E9D0", VA = "0x182D803D0")]
			public void Set(IStructure structure)
			{
			}

			// Token: 0x06000338 RID: 824 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x2D80490", Offset = "0x2D7EA90", VA = "0x182D80490")]
			public void Reset()
			{
			}

			// Token: 0x06000339 RID: 825 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x1B166E0", Offset = "0x1B14CE0", VA = "0x181B166E0")]
			public Structures()
			{
			}
		}
	}
}
