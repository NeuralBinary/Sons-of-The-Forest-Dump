using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000244 RID: 580
	[Token(Token = "0x2000244")]
	[AddComponentMenu("Sons/Construction/TarpStructure")]
	public class TarpStructure : Structure, IDetachedPlacementStructure, IBreakableStructure, IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06001184 RID: 4484 RVA: 0x0000A9C4 File Offset: 0x00008BC4
		[Token(Token = "0x17000402")]
		public override ushort TypeID
		{
			[Token(Token = "0x6001184")]
			[Address(RVA = "0x6C1D40", Offset = "0x6C0340", VA = "0x1806C1D40", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x0000A9DC File Offset: 0x00008BDC
		[Token(Token = "0x17000403")]
		public override int LinkedStructureCount
		{
			[Token(Token = "0x6001185")]
			[Address(RVA = "0x22F41B0", Offset = "0x22F27B0", VA = "0x1822F41B0", Slot = "50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001186 RID: 4486 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000404")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x6001186")]
			[Address(RVA = "0x2F263E0", Offset = "0x2F249E0", VA = "0x182F263E0", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000405")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x6001187")]
			[Address(RVA = "0x2F26430", Offset = "0x2F24A30", VA = "0x182F26430", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x0000A9F4 File Offset: 0x00008BF4
		[Token(Token = "0x17000406")]
		private bool IsOrientationFixed
		{
			[Token(Token = "0x6001188")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000407")]
		public static Counter Counter
		{
			[Token(Token = "0x6001189")]
			[Address(RVA = "0x2F26480", Offset = "0x2F24A80", VA = "0x182F26480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600118A")]
		[Address(RVA = "0x2F264D0", Offset = "0x2F24AD0", VA = "0x182F264D0")]
		private void InitMeshInstance()
		{
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600118B")]
		[Address(RVA = "0x2F26640", Offset = "0x2F24C40", VA = "0x182F26640", Slot = "88")]
		public override string GetDirName(int dir)
		{
			return null;
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x0000AA0C File Offset: 0x00008C0C
		[Token(Token = "0x600118C")]
		[Address(RVA = "0x2F26690", Offset = "0x2F24C90", VA = "0x182F26690", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600118D")]
		[Address(RVA = "0x2E5E670", Offset = "0x2E5CC70", VA = "0x182E5E670")]
		public void SetStructureAtDir(TarpDirections direction, IStructure structure)
		{
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600118E")]
		[Address(RVA = "0x2F267F0", Offset = "0x2F24DF0", VA = "0x182F267F0", Slot = "90")]
		public override void SetStructureAtDir(int direction, IStructure structure)
		{
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600118F")]
		public T GetStructureAtDir<T>(TarpDirections direction) where T : Structure
		{
			return null;
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001190")]
		[Address(RVA = "0x2F269B0", Offset = "0x2F24FB0", VA = "0x182F269B0", Slot = "59")]
		public override void OnPostLoad()
		{
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001191")]
		[Address(RVA = "0x2F26A40", Offset = "0x2F25040", VA = "0x182F26A40", Slot = "61")]
		public override void OnDestroyingStructure()
		{
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001192")]
		[Address(RVA = "0x2F26A80", Offset = "0x2F25080", VA = "0x182F26A80", Slot = "62")]
		public override void OnDestroyingStructureClient()
		{
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001193")]
		[Address(RVA = "0x2F26A90", Offset = "0x2F25090", VA = "0x182F26A90", Slot = "65")]
		public override void OnLinkedStructuresChanged()
		{
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001194")]
		[Address(RVA = "0x2F26A90", Offset = "0x2F25090", VA = "0x182F26A90", Slot = "66")]
		public override void OnLinkedStructuresChangedClient()
		{
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001195")]
		[Address(RVA = "0x2F26AA0", Offset = "0x2F250A0", VA = "0x182F26AA0", Slot = "64")]
		public override void OnElementsChangedClient()
		{
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001196")]
		[Address(RVA = "0x2F26AE0", Offset = "0x2F250E0", VA = "0x182F26AE0")]
		public void RefreshCollision()
		{
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001197")]
		[Address(RVA = "0x2F26DC0", Offset = "0x2F253C0", VA = "0x182F26DC0")]
		public void UpdateCorner(TarpDirections direction, IStructure structure)
		{
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001198")]
		[Address(RVA = "0x2F27120", Offset = "0x2F25720", VA = "0x182F27120")]
		public void UpdateCorner(TarpDirections direction, Vector3 worldPos)
		{
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001199")]
		[Address(RVA = "0x2F27350", Offset = "0x2F25950", VA = "0x182F27350")]
		public void RefreshStimuli()
		{
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x0000AA24 File Offset: 0x00008C24
		[Token(Token = "0x17000408")]
		private bool IsReinforced
		{
			[Token(Token = "0x600119A")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x0000AA3C File Offset: 0x00008C3C
		[Token(Token = "0x600119B")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "110")]
		private bool IsBreakable()
		{
			return default(bool);
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x0000AA54 File Offset: 0x00008C54
		[Token(Token = "0x600119C")]
		[Address(RVA = "0x2F27530", Offset = "0x2F25B30", VA = "0x182F27530", Slot = "111")]
		private float CalcBreakForce()
		{
			return 0f;
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600119D")]
		[Address(RVA = "0x2F27600", Offset = "0x2F25C00", VA = "0x182F27600")]
		public TarpStructure()
		{
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600119F")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "107")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60011A0")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60011A1")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60011A2")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x0000AA6C File Offset: 0x00008C6C
		[Token(Token = "0x60011A3")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011A4")]
		[Address(RVA = "0x2F27860", Offset = "0x2F25E60", VA = "0x182F27860")]
		[CompilerGenerated]
		private void <OnDestroyingStructure>g__BreakLoneStakes|22_0()
		{
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011A5")]
		[Address(RVA = "0x2F27AE0", Offset = "0x2F260E0", VA = "0x182F27AE0")]
		[CompilerGenerated]
		private void <OnDestroyingStructure>g__CleanUpSleepTrigger|22_1()
		{
		}

		// Token: 0x04000901 RID: 2305
		[Token(Token = "0x4000901")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x04000902 RID: 2306
		[Token(Token = "0x4000902")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Directions[] SupportedByDirs;

		// Token: 0x02000245 RID: 581
		[Token(Token = "0x2000245")]
		public static class Utils
		{
			// Token: 0x17000409 RID: 1033
			// (get) Token: 0x060011A6 RID: 4518 RVA: 0x0000AA84 File Offset: 0x00008C84
			// (set) Token: 0x060011A7 RID: 4519 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000409")]
			public static bool LoadingSaveMode
			{
				[Token(Token = "0x60011A6")]
				[Address(RVA = "0x2F27CA0", Offset = "0x2F262A0", VA = "0x182F27CA0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60011A7")]
				[Address(RVA = "0x2F27CE0", Offset = "0x2F262E0", VA = "0x182F27CE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060011A8 RID: 4520 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60011A8")]
			[Address(RVA = "0x2F27D20", Offset = "0x2F26320", VA = "0x182F27D20")]
			public static void CastToGround(TarpStructure tarpC)
			{
			}

			// Token: 0x060011A9 RID: 4521 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60011A9")]
			[Address(RVA = "0x2F27F00", Offset = "0x2F26500", VA = "0x182F27F00")]
			internal static void CalcTarpSnapPosFromFloor(FloorStructure targetFloor, out Vector3 snapPos)
			{
			}

			// Token: 0x060011AA RID: 4522 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60011AA")]
			[Address(RVA = "0x2F28010", Offset = "0x2F26610", VA = "0x182F28010")]
			public static void TryAddSleepTrigger(TarpStructure tarp, StructureElement sleepTriggerPrefab)
			{
			}
		}
	}
}
