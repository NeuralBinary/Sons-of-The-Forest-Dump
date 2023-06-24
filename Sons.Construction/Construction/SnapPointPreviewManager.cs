using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000119 RID: 281
	[Token(Token = "0x2000119")]
	[AddComponentMenu("Sons/Construction/SnapPointPreviewManager")]
	public class SnapPointPreviewManager : MonoBehaviour, IPreviewManager
	{
		// Token: 0x060007BB RID: 1979 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x2E4A980", Offset = "0x2E48F80", VA = "0x182E4A980")]
		private void Update()
		{
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x2E4AE20", Offset = "0x2E49420", VA = "0x182E4AE20")]
		public void SetTargeted(Structure structure)
		{
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x2E4B240", Offset = "0x2E49840", VA = "0x182E4B240")]
		public void ResetFrameTargets()
		{
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x2E4B2A0", Offset = "0x2E498A0", VA = "0x182E4B2A0")]
		public void SetDirty(IStructure structure)
		{
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x2E4B240", Offset = "0x2E49840", VA = "0x182E4B240", Slot = "4")]
		public void Hide()
		{
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x2E4B410", Offset = "0x2E49A10", VA = "0x182E4B410")]
		private void ClearPrevFrameTargets()
		{
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00005264 File Offset: 0x00003464
		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x2E4B800", Offset = "0x2E49E00", VA = "0x182E4B800")]
		private bool TryGetIndexOf(IStructure structure, out int index)
		{
			return default(bool);
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x2E4B8D0", Offset = "0x2E49ED0", VA = "0x182E4B8D0")]
		private void InitStructureSnappointVisuals(SnapPointPreviewManager.StructureData structureData)
		{
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x2E4BBB0", Offset = "0x2E4A1B0", VA = "0x182E4BBB0")]
		private void UpdateStructureAimScore(SnapPointPreviewManager.StructureData structureData, TargetInfo targetInfo)
		{
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x2E4BF50", Offset = "0x2E4A550", VA = "0x182E4BF50")]
		private void UpdateStructureVisuals(SnapPointPreviewManager.StructureData structureData, TargetInfo targetInfo)
		{
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x2E4C350", Offset = "0x2E4A950", VA = "0x182E4C350")]
		private void UnloadStructureSnapPointVisuals(SnapPointPreviewManager.StructureData structureData)
		{
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x2E4C600", Offset = "0x2E4AC00", VA = "0x182E4C600")]
		private Transform GetVisualInstance()
		{
			return null;
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x2E4C8A0", Offset = "0x2E4AEA0", VA = "0x182E4C8A0")]
		private void UpdateStructureSnappoints(SnapPointPreviewManager.StructureData structureData)
		{
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x2E4C970", Offset = "0x2E4AF70", VA = "0x182E4C970")]
		private void UpdateSnapPoints(SnapPointPreviewManager.StructureData structureData, PilarStructure pilar)
		{
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x2E4D7F0", Offset = "0x2E4BDF0", VA = "0x182E4D7F0")]
		public SnapPointPreviewManager()
		{
		}

		// Token: 0x040005D6 RID: 1494
		[Token(Token = "0x40005D6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("will be disabled while showing, can be used to override other preview systems.")]
		private ConstructionManager _manager;

		// Token: 0x040005D7 RID: 1495
		[Token(Token = "0x40005D7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _visualPrefab;

		// Token: 0x040005D8 RID: 1496
		[Token(Token = "0x40005D8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _offset;

		// Token: 0x040005D9 RID: 1497
		[Token(Token = "0x40005D9")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _alphaSaturationPower;

		// Token: 0x040005DA RID: 1498
		[Token(Token = "0x40005DA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _seeThroughMatMaxAlpha;

		// Token: 0x040005DB RID: 1499
		[Token(Token = "0x40005DB")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _showDuration;

		// Token: 0x040005DC RID: 1500
		[Token(Token = "0x40005DC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _hideDuration;

		// Token: 0x040005DD RID: 1501
		[Token(Token = "0x40005DD")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _targetSnappointAlphaOffset;

		// Token: 0x040005DE RID: 1502
		[Token(Token = "0x40005DE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _colorParameter;

		// Token: 0x040005DF RID: 1503
		[Token(Token = "0x40005DF")]
		[FieldOffset(Offset = "0x50")]
		private Queue<Transform> _visualPool;

		// Token: 0x040005E0 RID: 1504
		[Token(Token = "0x40005E0")]
		[FieldOffset(Offset = "0x58")]
		private List<SnapPointPreviewManager.StructureData> _knownStructures;

		// Token: 0x040005E1 RID: 1505
		[Token(Token = "0x40005E1")]
		[FieldOffset(Offset = "0x60")]
		private List<SnapPointPreviewManager.StructureData> _pendingUpdate;

		// Token: 0x040005E2 RID: 1506
		[Token(Token = "0x40005E2")]
		[FieldOffset(Offset = "0x68")]
		private List<SnapPointPreviewManager.StructureData> _frameTargets;

		// Token: 0x040005E3 RID: 1507
		[Token(Token = "0x40005E3")]
		[FieldOffset(Offset = "0x70")]
		private List<SnapPointPreviewManager.StructureData> _prevFrameTargets;

		// Token: 0x040005E4 RID: 1508
		[Token(Token = "0x40005E4")]
		[FieldOffset(Offset = "0x78")]
		private List<SnapPointPreviewManager.StructureData> _residualTargets;

		// Token: 0x0200011A RID: 282
		[Token(Token = "0x200011A")]
		[Serializable]
		public struct SnappointData
		{
			// Token: 0x17000246 RID: 582
			// (get) Token: 0x060007CA RID: 1994 RVA: 0x0000527C File Offset: 0x0000347C
			// (set) Token: 0x060007CB RID: 1995 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000246")]
			public Directions EditingDir
			{
				[Token(Token = "0x60007CA")]
				[Address(RVA = "0x60E050", Offset = "0x60C650", VA = "0x18060E050")]
				[CompilerGenerated]
				readonly get
				{
					return Directions.LeafStructureSupport;
				}
				[Token(Token = "0x60007CB")]
				[Address(RVA = "0x634E70", Offset = "0x633470", VA = "0x180634E70")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000247 RID: 583
			// (get) Token: 0x060007CC RID: 1996 RVA: 0x00005294 File Offset: 0x00003494
			// (set) Token: 0x060007CD RID: 1997 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000247")]
			public Directions Support1Dir
			{
				[Token(Token = "0x60007CC")]
				[Address(RVA = "0x9895F0", Offset = "0x987BF0", VA = "0x1809895F0")]
				[CompilerGenerated]
				readonly get
				{
					return Directions.LeafStructureSupport;
				}
				[Token(Token = "0x60007CD")]
				[Address(RVA = "0x989600", Offset = "0x987C00", VA = "0x180989600")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000248 RID: 584
			// (get) Token: 0x060007CE RID: 1998 RVA: 0x000052AC File Offset: 0x000034AC
			// (set) Token: 0x060007CF RID: 1999 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000248")]
			public Vector3 TargetingAxis
			{
				[Token(Token = "0x60007CE")]
				[Address(RVA = "0x633690", Offset = "0x631C90", VA = "0x180633690")]
				[CompilerGenerated]
				readonly get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007CF")]
				[Address(RVA = "0x2E4DBC0", Offset = "0x2E4C1C0", VA = "0x182E4DBC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000249 RID: 585
			// (get) Token: 0x060007D0 RID: 2000 RVA: 0x000052C4 File Offset: 0x000034C4
			// (set) Token: 0x060007D1 RID: 2001 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000249")]
			public Vector3 WorldPos
			{
				[Token(Token = "0x60007D0")]
				[Address(RVA = "0xAA8B50", Offset = "0xAA7150", VA = "0x180AA8B50")]
				[CompilerGenerated]
				readonly get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007D1")]
				[Address(RVA = "0x290B4E0", Offset = "0x2909AE0", VA = "0x18290B4E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700024A RID: 586
			// (get) Token: 0x060007D2 RID: 2002 RVA: 0x000052DC File Offset: 0x000034DC
			// (set) Token: 0x060007D3 RID: 2003 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700024A")]
			public Quaternion WorldRot
			{
				[Token(Token = "0x60007D2")]
				[Address(RVA = "0xAA8B70", Offset = "0xAA7170", VA = "0x180AA8B70")]
				[CompilerGenerated]
				readonly get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60007D3")]
				[Address(RVA = "0x20C00C0", Offset = "0x20BE6C0", VA = "0x1820C00C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700024B RID: 587
			// (get) Token: 0x060007D4 RID: 2004 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x060007D5 RID: 2005 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700024B")]
			public Transform VisualInstance
			{
				[Token(Token = "0x60007D4")]
				[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x60007D5")]
				[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700024C RID: 588
			// (get) Token: 0x060007D6 RID: 2006 RVA: 0x000052F4 File Offset: 0x000034F4
			// (set) Token: 0x060007D7 RID: 2007 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700024C")]
			public float AimScore
			{
				[Token(Token = "0x60007D6")]
				[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320")]
				[CompilerGenerated]
				readonly get
				{
					return 0f;
				}
				[Token(Token = "0x60007D7")]
				[Address(RVA = "0x207C3C0", Offset = "0x207A9C0", VA = "0x18207C3C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060007D8 RID: 2008 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x2E4DBC0", Offset = "0x2E4C1C0", VA = "0x182E4DBC0")]
			public void SetTargetingAxis(Vector3 axis)
			{
			}

			// Token: 0x060007D9 RID: 2009 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x290B4E0", Offset = "0x2909AE0", VA = "0x18290B4E0")]
			public void SetWorldPos(Vector3 worldPos)
			{
			}

			// Token: 0x060007DA RID: 2010 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x20C00C0", Offset = "0x20BE6C0", VA = "0x1820C00C0")]
			public void SetWorldRot(Quaternion worldRot)
			{
			}

			// Token: 0x060007DB RID: 2011 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			public void SetVisualInstance(Transform visualInstance)
			{
			}

			// Token: 0x060007DC RID: 2012 RVA: 0x0000530C File Offset: 0x0000350C
			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x2E4DBD0", Offset = "0x2E4C1D0", VA = "0x182E4DBD0")]
			public bool IsMatchingDirection(TargetInfo targetInfo)
			{
				return default(bool);
			}
		}

		// Token: 0x0200011B RID: 283
		[Token(Token = "0x200011B")]
		[Serializable]
		public class StructureData
		{
			// Token: 0x1700024D RID: 589
			// (get) Token: 0x060007DD RID: 2013 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700024D")]
			public IStructure Instance
			{
				[Token(Token = "0x60007DD")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x1700024E RID: 590
			// (get) Token: 0x060007DE RID: 2014 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700024E")]
			public List<SnapPointPreviewManager.SnappointData> SnapPoints
			{
				[Token(Token = "0x60007DE")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x1700024F RID: 591
			// (get) Token: 0x060007DF RID: 2015 RVA: 0x00005324 File Offset: 0x00003524
			// (set) Token: 0x060007E0 RID: 2016 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700024F")]
			public float LoadProgress
			{
				[Token(Token = "0x60007DF")]
				[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60007E0")]
				[Address(RVA = "0x5EA830", Offset = "0x5E8E30", VA = "0x1805EA830")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060007E1 RID: 2017 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x2E4DC20", Offset = "0x2E4C220", VA = "0x182E4DC20")]
			public StructureData(Structure instance)
			{
			}
		}
	}
}
