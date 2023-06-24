using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Construction.Anim;
using Il2CppDummyDll;
using Sons.Construction.Branching;
using Sons.Inventory;
using Sons.Items.Core;
using UnityEngine;

namespace Construction
{
	// Token: 0x020000A8 RID: 168
	[Token(Token = "0x20000A8")]
	[AddComponentMenu("Sons/Construction/ConstructionManager")]
	public class ConstructionManager : MonoBehaviour, IPlaceActionCompletedReceiver
	{
		// Token: 0x0600047D RID: 1149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x2E0BBB0", Offset = "0x2E0A1B0", VA = "0x182E0BBB0")]
		private void InitCallbacks()
		{
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x2E0BD20", Offset = "0x2E0A320", VA = "0x182E0BD20")]
		private void CleanUpCallbacks()
		{
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x2E0BDF0", Offset = "0x2E0A3F0", VA = "0x182E0BDF0")]
		private void OnBeforeLoadSave()
		{
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x2E0BE90", Offset = "0x2E0A490", VA = "0x182E0BE90")]
		private void OnAfterLoadSave()
		{
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x2E0BF80", Offset = "0x2E0A580", VA = "0x182E0BF80")]
		private void InitCommands()
		{
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00004004 File Offset: 0x00002204
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x2E0C0D0", Offset = "0x2E0A6D0", VA = "0x182E0C0D0")]
		private bool CountLinkedStructures(string s)
		{
			return default(bool);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0000401C File Offset: 0x0000221C
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x2E0C6E0", Offset = "0x2E0ACE0", VA = "0x182E0C6E0")]
		private bool ExportLinkedStructuresToJson(string fileName)
		{
			return default(bool);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00004034 File Offset: 0x00002234
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x2E0CD80", Offset = "0x2E0B380", VA = "0x182E0CD80")]
		private bool ImportLinkedStructuresFromFile(string fileName)
		{
			return default(bool);
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000179")]
		public PreviewManager Previews
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x0000404C File Offset: 0x0000224C
		[Token(Token = "0x1700017A")]
		public InputModes ActivationInputMode
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return InputModes.AlwaysTwoSteps;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700017B")]
		public ConstructionManager.ItemManager Items
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x671190", Offset = "0x66F790", VA = "0x180671190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x728460", Offset = "0x726A60", VA = "0x180728460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700017C")]
		public ConstructionManager.PlayerInfo Player
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x8ECC80", Offset = "0x8EB280", VA = "0x1808ECC80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x8ECC90", Offset = "0x8EB290", VA = "0x1808ECC90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700017D")]
		public ItemData HeldItem
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x2E0D8B0", Offset = "0x2E0BEB0", VA = "0x182E0D8B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700017E")]
		public PlayerBuildingModeAction BuildingModeActions
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700017F")]
		public ConstructionSettings Settings
		{
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000180")]
		public TargetInfo CurrentTarget
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x2E0D8D0", Offset = "0x2E0BED0", VA = "0x182E0D8D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10")]
			private set
			{
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000181")]
		public TargetInfo CurrentTargetOverride
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x737410", Offset = "0x735A10", VA = "0x180737410")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x8DD040", Offset = "0x8DB640", VA = "0x1808DD040")]
			set
			{
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000182")]
		public IConstructionModule ActiveModule
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x2E0D8F0", Offset = "0x2E0BEF0", VA = "0x182E0D8F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000183")]
		public ModuleState ActiveModuleState
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x2E0D910", Offset = "0x2E0BF10", VA = "0x182E0D910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00004064 File Offset: 0x00002264
		[Token(Token = "0x17000184")]
		public Vector3 CastOrigin
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x2E0D950", Offset = "0x2E0BF50", VA = "0x182E0D950")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000185")]
		public IAimRayProvider AimRayProvider
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0000407C File Offset: 0x0000227C
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000186")]
		public float CurrentRotationAngleDegrees
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x27399D0", Offset = "0x2737FD0", VA = "0x1827399D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x2E0D9D0", Offset = "0x2E0BFD0", VA = "0x182E0D9D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00004094 File Offset: 0x00002294
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000187")]
		public float MaxTargetDistance
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x2805EE0", Offset = "0x28044E0", VA = "0x182805EE0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x2E0D9E0", Offset = "0x2E0BFE0", VA = "0x182E0D9E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x000040AC File Offset: 0x000022AC
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000188")]
		public float MaxFlatTargetDistance
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x69B270", Offset = "0x699870", VA = "0x18069B270")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x270E6C0", Offset = "0x270CCC0", VA = "0x18270E6C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x000040C4 File Offset: 0x000022C4
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000189")]
		public bool CanPlaceOnTerrain
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x2E0D9F0", Offset = "0x2E0BFF0", VA = "0x182E0D9F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x2E0DA00", Offset = "0x2E0C000", VA = "0x182E0DA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x000040DC File Offset: 0x000022DC
		[Token(Token = "0x1700018A")]
		public bool RunningBlockingRoutine
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x2E0DA10", Offset = "0x2E0C010", VA = "0x182E0DA10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x000040F4 File Offset: 0x000022F4
		[Token(Token = "0x1700018B")]
		public static bool DemoMode
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x2E0DA30", Offset = "0x2E0C030", VA = "0x182E0DA30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x0000410C File Offset: 0x0000230C
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700018C")]
		public bool AdvancedBuildMode
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x2E0DA50", Offset = "0x2E0C050", VA = "0x182E0DA50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x2E0DA60", Offset = "0x2E0C060", VA = "0x182E0DA60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00004124 File Offset: 0x00002324
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700018D")]
		public bool AllowFreeFormInCaves
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x2E0DA70", Offset = "0x2E0C070", VA = "0x182E0DA70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x2E0DA80", Offset = "0x2E0C080", VA = "0x182E0DA80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x0000413C File Offset: 0x0000233C
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700018E")]
		public bool SlowDownMovingLogsForCuts
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x2E0DA90", Offset = "0x2E0C090", VA = "0x182E0DA90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x2E0DAA0", Offset = "0x2E0C0A0", VA = "0x182E0DAA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00004154 File Offset: 0x00002354
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700018F")]
		public bool SkipPlaceAnimations
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x61BF20", Offset = "0x61A520", VA = "0x18061BF20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x61BF30", Offset = "0x61A530", VA = "0x18061BF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x2E0DAB0", Offset = "0x2E0C0B0", VA = "0x182E0DAB0")]
		private void Start()
		{
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x2E0EC80", Offset = "0x2E0D280", VA = "0x182E0EC80")]
		private void Update()
		{
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x2E0F0E0", Offset = "0x2E0D6E0", VA = "0x182E0F0E0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x2E0F190", Offset = "0x2E0D790", VA = "0x182E0F190")]
		private void OnDisable()
		{
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x2E0F1A0", Offset = "0x2E0D7A0", VA = "0x182E0F1A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x2E0F360", Offset = "0x2E0D960", VA = "0x182E0F360")]
		public void GrabPlayerPosition()
		{
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x2E0F390", Offset = "0x2E0D990", VA = "0x182E0F390")]
		public void RunBlocking(IEnumerator routine, [Optional] Action onCancelCallback, float killDelay = 3f)
		{
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x2E0F3C0", Offset = "0x2E0D9C0", VA = "0x182E0F3C0")]
		private void StageModule(IConstructionModule module, ModuleProfile profile)
		{
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x2E0F3F0", Offset = "0x2E0D9F0", VA = "0x182E0F3F0")]
		public void ActivateModule(IConstructionModule module)
		{
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x2E0F420", Offset = "0x2E0DA20", VA = "0x182E0F420")]
		private void ShowDebugGizmos()
		{
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x2E0F510", Offset = "0x2E0DB10", VA = "0x182E0F510")]
		public void AddElementToStructure(Structure structure, IPlaceElementProfile profile)
		{
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x2E0F930", Offset = "0x2E0DF30", VA = "0x182E0F930")]
		public void AddElementToStructure(ITargetablePlacement structure, Vector3 worldPos, IPlaceElementProfile profile)
		{
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x2E0FCA0", Offset = "0x2E0E2A0", VA = "0x182E0FCA0")]
		public void AddElementToStructure(Structure structure, Vector3 worldPos, Quaternion rot, IPlaceElementProfile profile)
		{
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x2E100A0", Offset = "0x2E0E6A0", VA = "0x182E100A0")]
		public void CleanupVegetation(StructureElement instance)
		{
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x2E100C0", Offset = "0x2E0E6C0", VA = "0x182E100C0")]
		public void ResetAll(UiMessages uiMessages = UiMessages.None)
		{
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x2E102C0", Offset = "0x2E0E8C0", VA = "0x182E102C0")]
		public void Register(IIdleStateUpdateReceiver receiver, int insertIndex = -1)
		{
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x2E103B0", Offset = "0x2E0E9B0", VA = "0x182E103B0")]
		public void Register(IBeginPlaceActionReceiver receiver)
		{
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x2E10450", Offset = "0x2E0EA50", VA = "0x182E10450")]
		public void Register(IStoppedPlaceActionReceiver receiver)
		{
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x2E104F0", Offset = "0x2E0EAF0", VA = "0x182E104F0")]
		public void EnablePlacePrompt(UiMessages messages = UiMessages.PlaceAndCancel)
		{
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x2E10560", Offset = "0x2E0EB60", VA = "0x182E10560")]
		public void BeginPlaceAction()
		{
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x2E10810", Offset = "0x2E0EE10", VA = "0x182E10810", Slot = "5")]
		public void PlaceActionCompleted()
		{
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x2E10850", Offset = "0x2E0EE50", VA = "0x182E10850", Slot = "4")]
		public void PlaceActionCompletedNoReset()
		{
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x2E10890", Offset = "0x2E0EE90", VA = "0x182E10890")]
		private void AnimationTriggeredPlace()
		{
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0000416C File Offset: 0x0000236C
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x2E10A30", Offset = "0x2E0F030", VA = "0x182E10A30")]
		public bool HasLineOfSight(Vector3 detachedPos)
		{
			return default(bool);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x2E10B80", Offset = "0x2E0F180", VA = "0x182E10B80")]
		private void InitSettings()
		{
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x2E10F50", Offset = "0x2E0F550", VA = "0x182E10F50")]
		private void CleanUpSettings()
		{
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x2E0DA60", Offset = "0x2E0C060", VA = "0x182E0DA60")]
		private void SetAdvancedBuildMode(bool isOn)
		{
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x2E0DA80", Offset = "0x2E0C080", VA = "0x182E0DA80")]
		private void SetAllowFreeFormInCaves(bool isOn)
		{
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x2E0DAA0", Offset = "0x2E0C0A0", VA = "0x182E0DAA0")]
		private void SetSlowDownMovingLogsForCuts(bool isOn)
		{
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x61BF30", Offset = "0x61A530", VA = "0x18061BF30")]
		private void SetSkipPlaceAnimations(bool isOn)
		{
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x2E11190", Offset = "0x2E0F790", VA = "0x182E11190")]
		private static void SetTrampolineVelocityMultiplier(float val)
		{
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x2E111F0", Offset = "0x2E0F7F0", VA = "0x182E111F0")]
		private static void SetTrampolineMaxVelocity(float val)
		{
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x2E11250", Offset = "0x2E0F850", VA = "0x182E11250")]
		public ConstructionManager()
		{
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x2E11810", Offset = "0x2E0FE10", VA = "0x182E11810")]
		[CompilerGenerated]
		private IEnumerator <OnAfterLoadSave>g__DelayedEnable|3_0()
		{
			return null;
		}

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("Input Settings")]
		private InputModes _activationInputMode;

		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("Settings")]
		private PhysicsCaster _physicsCaster;

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ConstructionManager.PredictedSnapPointRepository _predictedSnapPointRepos;

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ConstructionManager.ModuleStateManager _moduleStateManager;

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ConstructionManager.NonPredictedTargetsLookup _nonPredictedTargetsLookup;

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ConstructionManager.PredictedSnapPointsLookup _predictedSnapPointsLookup;

		// Token: 0x04000432 RID: 1074
		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("References")]
		[SerializeField]
		private PreviewManager _previews;

		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private EnvironmentCleanupManager _environmentCleanupManager;

		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ElementProfileDatabase _elementProfileDatabase;

		// Token: 0x04000435 RID: 1077
		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private PlayerBuildingModeAction _animationManager;

		// Token: 0x04000436 RID: 1078
		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ConstructionSettings _constructionSettings;

		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TargetInfo _currentTarget;

		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TargetInfo _currentTargetOverride;

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ConstructionManager.StagedModuleInfo _staged;

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ConstructionManager.ActiveModuleInfo _activeModule;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ConstructionManager.BlockingRoutineManager _blockingRoutine;

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly List<IIdleStateUpdateReceiver> _idleStateReceivers;

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly List<IBeginPlaceActionReceiver> _beginPlaceAnimationReceivers;

		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private readonly List<IStoppedPlaceActionReceiver> _stoppedPlaceAnimationReceivers;

		// Token: 0x020000A9 RID: 169
		[Token(Token = "0x20000A9")]
		public class DirtyAreasOperation : IAreaProcessor
		{
			// Token: 0x060004CC RID: 1228 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			public void Init(ConstructionManager.PredictedSnapPointRepository repository)
			{
			}

			// Token: 0x060004CD RID: 1229 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x2E119D0", Offset = "0x2E0FFD0", VA = "0x182E119D0", Slot = "4")]
			private void ProcessArea(Vector3Int area)
			{
			}

			// Token: 0x060004CE RID: 1230 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public DirtyAreasOperation()
			{
			}

			// Token: 0x04000449 RID: 1097
			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private ConstructionManager.PredictedSnapPointRepository _repository;
		}

		// Token: 0x020000AA RID: 170
		[Token(Token = "0x20000AA")]
		public class LookupMissingGridAreasOperation : IAreaProcessor
		{
			// Token: 0x060004CF RID: 1231 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x2E11BA0", Offset = "0x2E101A0", VA = "0x182E11BA0")]
			public void Init(ConstructionManager manager)
			{
			}

			// Token: 0x060004D0 RID: 1232 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x2E11CF0", Offset = "0x2E102F0", VA = "0x182E11CF0", Slot = "4")]
			private void ProcessArea(Vector3Int area)
			{
			}

			// Token: 0x060004D1 RID: 1233 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x2E12010", Offset = "0x2E10610", VA = "0x182E12010")]
			private void InitAllGridTargets()
			{
			}

			// Token: 0x060004D2 RID: 1234 RVA: 0x00004184 File Offset: 0x00002384
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x2E124E0", Offset = "0x2E10AE0", VA = "0x182E124E0")]
			public Vector3Int GetStructureArea(Transform structureTr)
			{
				return default(Vector3Int);
			}

			// Token: 0x060004D3 RID: 1235 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public LookupMissingGridAreasOperation()
			{
			}

			// Token: 0x0400044A RID: 1098
			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private ConstructionManager.PredictedSnapPointRepository _repository;

			// Token: 0x0400044B RID: 1099
			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private ConstructionManager.PredictedSnapPointsLookup _predictedSnapPointsLookup;

			// Token: 0x0400044C RID: 1100
			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private PhysicsCaster _physicsCaster;

			// Token: 0x0400044D RID: 1101
			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float _areaSize;
		}

		// Token: 0x020000AB RID: 171
		[Token(Token = "0x20000AB")]
		[Serializable]
		public class NonPredictedTargetsLookup
		{
			// Token: 0x17000190 RID: 400
			// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000190")]
			public ConstructionManager Manager
			{
				[Token(Token = "0x60004D4")]
				[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60004D5")]
				[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000191 RID: 401
			// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x060004D7 RID: 1239 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000191")]
			public ConstructionSystem System
			{
				[Token(Token = "0x60004D6")]
				[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60004D7")]
				[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000192 RID: 402
			// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x060004D9 RID: 1241 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000192")]
			public ConstructionManager.ModuleStateManager StatesManager
			{
				[Token(Token = "0x60004D8")]
				[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60004D9")]
				[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000193 RID: 403
			// (get) Token: 0x060004DA RID: 1242 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x060004DB RID: 1243 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000193")]
			public PhysicsCaster PhysicsCaster
			{
				[Token(Token = "0x60004DA")]
				[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60004DB")]
				[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060004DC RID: 1244 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x2E125F0", Offset = "0x2E10BF0", VA = "0x182E125F0")]
			public void Init(ConstructionManager constructionManager)
			{
			}

			// Token: 0x060004DD RID: 1245 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x2E12960", Offset = "0x2E10F60", VA = "0x182E12960")]
			public void LookUpAvailableModules(bool highPriority)
			{
			}

			// Token: 0x060004DE RID: 1246 RVA: 0x0000419C File Offset: 0x0000239C
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x2E133A0", Offset = "0x2E119A0", VA = "0x182E133A0")]
			public bool TryLookupDynamicSnapPoint(bool performPhysicsLookup, out bool performedPhysicsLookup)
			{
				return default(bool);
			}

			// Token: 0x060004DF RID: 1247 RVA: 0x000041B4 File Offset: 0x000023B4
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x2E135A0", Offset = "0x2E11BA0", VA = "0x182E135A0")]
			private bool LookupDynamicTargetsAndStageModule(List<IDynamicSnapPointModule> onStructureModules, List<IDynamicSnapPointModule> onOtherTargetModules)
			{
				return default(bool);
			}

			// Token: 0x060004E0 RID: 1248 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x2E13C90", Offset = "0x2E12290", VA = "0x182E13C90")]
			private void InitAllTargets(LookupType lookupType)
			{
			}

			// Token: 0x060004E1 RID: 1249 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x2E13EE0", Offset = "0x2E124E0", VA = "0x182E13EE0")]
			public NonPredictedTargetsLookup()
			{
			}

			// Token: 0x060004E2 RID: 1250 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x2E14140", Offset = "0x2E12740", VA = "0x182E14140")]
			[CompilerGenerated]
			private void <TryLookupDynamicSnapPoint>g__CalculateDistanceSortedHitIndexes|22_0()
			{
			}

			// Token: 0x060004E3 RID: 1251 RVA: 0x000041CC File Offset: 0x000023CC
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x2E146B0", Offset = "0x2E12CB0", VA = "0x182E146B0")]
			[CompilerGenerated]
			private int <LookupDynamicTargetsAndStageModule>g__InitCurrentTarget|23_0(int i)
			{
				return 0;
			}

			// Token: 0x060004E4 RID: 1252 RVA: 0x000041E4 File Offset: 0x000023E4
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x2E14880", Offset = "0x2E12E80", VA = "0x182E14880")]
			[CompilerGenerated]
			internal static bool <InitAllTargets>g__IsInvalidDynamicTarget|24_0(GameObject targetGo)
			{
				return default(bool);
			}

			// Token: 0x0400044E RID: 1102
			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private TargetInfo[] _targets;

			// Token: 0x0400044F RID: 1103
			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private List<int> _hitResultSortedIndexes;

			// Token: 0x04000450 RID: 1104
			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private List<IDynamicSnapPointModule> _availableOnStructureModules;

			// Token: 0x04000451 RID: 1105
			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<IDynamicSnapPointModule> _availableOnOtherTargetModules;
		}

		// Token: 0x020000AC RID: 172
		[Token(Token = "0x20000AC")]
		[Serializable]
		public class PredictedSnapPointGrid
		{
			// Token: 0x17000194 RID: 404
			// (get) Token: 0x060004E5 RID: 1253 RVA: 0x000041FC File Offset: 0x000023FC
			[Token(Token = "0x17000194")]
			public float AreaSize
			{
				[Token(Token = "0x60004E5")]
				[Address(RVA = "0xA308D0", Offset = "0xA2EED0", VA = "0x180A308D0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000195 RID: 405
			// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00004214 File Offset: 0x00002414
			[Token(Token = "0x17000195")]
			public Vector3 AreaVolume
			{
				[Token(Token = "0x60004E6")]
				[Address(RVA = "0x2E14C00", Offset = "0x2E13200", VA = "0x182E14C00")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x060004E7 RID: 1255 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x2E14C20", Offset = "0x2E13220", VA = "0x182E14C20")]
			public void ForeachNearbyArea(Vector3 worldPos, int maxAreaDistance, IAreaProcessor areaProcessor)
			{
			}

			// Token: 0x060004E8 RID: 1256 RVA: 0x0000422C File Offset: 0x0000242C
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x2E14F40", Offset = "0x2E13540", VA = "0x182E14F40")]
			public Vector3Int WorldToAreaCoords(Vector3 worldPos, out Vector3Int offshoot)
			{
				return default(Vector3Int);
			}

			// Token: 0x060004E9 RID: 1257 RVA: 0x00004244 File Offset: 0x00002444
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x2E15060", Offset = "0x2E13660", VA = "0x182E15060")]
			public Vector3 AreaToCenterInWorld(Vector3Int area)
			{
				return default(Vector3);
			}

			// Token: 0x060004EA RID: 1258 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x2D636D0", Offset = "0x2D61CD0", VA = "0x182D636D0")]
			public PredictedSnapPointGrid()
			{
			}

			// Token: 0x04000456 RID: 1110
			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private float _areaSize;
		}

		// Token: 0x020000AD RID: 173
		[Token(Token = "0x20000AD")]
		[Serializable]
		public class PredictedSnapPointRepository : IStructureDirtyReceiver
		{
			// Token: 0x17000196 RID: 406
			// (get) Token: 0x060004EB RID: 1259 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x060004EC RID: 1260 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000196")]
			public ConstructionManager Manager
			{
				[Token(Token = "0x60004EB")]
				[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60004EC")]
				[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000197 RID: 407
			// (get) Token: 0x060004ED RID: 1261 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x060004EE RID: 1262 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000197")]
			public ConstructionManager.ModuleStateManager StatesManager
			{
				[Token(Token = "0x60004ED")]
				[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60004EE")]
				[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000198 RID: 408
			// (get) Token: 0x060004EF RID: 1263 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000198")]
			public HashSet<Vector3Int> CastAreas
			{
				[Token(Token = "0x60004EF")]
				[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000199 RID: 409
			// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000199")]
			public Dictionary<Vector3Int, PredictedAreaData> PredictedAreas
			{
				[Token(Token = "0x60004F0")]
				[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x1700019A RID: 410
			// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700019A")]
			public ConstructionManager.PredictedSnapPointGrid Grid
			{
				[Token(Token = "0x60004F1")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700019B RID: 411
			// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700019B")]
			public ConstructionManager.PredictedSnapPointsDebug Debug
			{
				[Token(Token = "0x60004F2")]
				[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
				get
				{
					return null;
				}
			}

			// Token: 0x060004F3 RID: 1267 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x2E150C0", Offset = "0x2E136C0", VA = "0x182E150C0")]
			public void Init(ConstructionManager manager)
			{
			}

			// Token: 0x060004F4 RID: 1268 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x2E15380", Offset = "0x2E13980", VA = "0x182E15380")]
			public void OnDestroy()
			{
			}

			// Token: 0x060004F5 RID: 1269 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x2E15470", Offset = "0x2E13A70", VA = "0x182E15470")]
			private void ClearAllCache()
			{
			}

			// Token: 0x060004F6 RID: 1270 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x2E15740", Offset = "0x2E13D40", VA = "0x182E15740", Slot = "4")]
			public void OnStructureDirty(IStructure editingStructure)
			{
			}

			// Token: 0x060004F7 RID: 1271 RVA: 0x0000425C File Offset: 0x0000245C
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x2E15890", Offset = "0x2E13E90", VA = "0x182E15890")]
			public Vector3 GetLookupCenterPos()
			{
				return default(Vector3);
			}

			// Token: 0x060004F8 RID: 1272 RVA: 0x00004274 File Offset: 0x00002474
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x2E159F0", Offset = "0x2E13FF0", VA = "0x182E159F0")]
			public bool TryLookupPredictedSnapPoint()
			{
				return default(bool);
			}

			// Token: 0x060004F9 RID: 1273 RVA: 0x0000428C File Offset: 0x0000248C
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x2E15F60", Offset = "0x2E14560", VA = "0x182E15F60")]
			private bool CheckOcclusionFree(PredictedTarget target)
			{
				return default(bool);
			}

			// Token: 0x060004FA RID: 1274 RVA: 0x000042A4 File Offset: 0x000024A4
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x2E15FA0", Offset = "0x2E145A0", VA = "0x182E15FA0")]
			private bool CheckOcclusionFree(Vector3 targetPos, Transform targetTr)
			{
				return default(bool);
			}

			// Token: 0x060004FB RID: 1275 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x2DDE500", Offset = "0x2DDCB00", VA = "0x182DDE500")]
			public void SetLookedUpArea(Vector3Int area)
			{
			}

			// Token: 0x060004FC RID: 1276 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x2E16470", Offset = "0x2E14A70", VA = "0x182E16470")]
			private PredictedAreaData GetPredictedAreaData(Vector3Int area)
			{
				return null;
			}

			// Token: 0x060004FD RID: 1277 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x2E16620", Offset = "0x2E14C20", VA = "0x182E16620")]
			public PredictedTarget RegisterSnapPoint(ISnapPointPredictingModule module, ModuleProfile profile, TargetInfo targetInfo, float size = 1f, int placementMode = 0, [Optional] Vector3 lookAxis, float lookAxisMaxDot = 1f)
			{
				return null;
			}

			// Token: 0x060004FE RID: 1278 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x2E166E0", Offset = "0x2E14CE0", VA = "0x182E166E0")]
			public PredictedTarget RegisterSnapPoint(ISnapPointPredictingModule module, ModuleProfile profile, ItemData heldItem, TargetInfo targetInfo, float size = 1f, int placementMode = 0, [Optional] Vector3 lookAxis, float lookAxisMaxDot = 1f)
			{
				return null;
			}

			// Token: 0x060004FF RID: 1279 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x2E16790", Offset = "0x2E14D90", VA = "0x182E16790")]
			public PredictedTarget RegisterSnapPoint(ISnapPointPredictingModule module, ModuleProfile profile, TargetInfo targetInfo, Vector3 customTargetPos, float size = 1f, int placementMode = 0, [Optional] Vector3 lookAxis, float lookAxisMaxDot = 1f)
			{
				return null;
			}

			// Token: 0x06000500 RID: 1280 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x2E16850", Offset = "0x2E14E50", VA = "0x182E16850")]
			public PredictedTarget RegisterSnapPoint(ISnapPointPredictingModule module, ModuleProfile profile, ItemData heldItem, TargetInfo snapPointTargetInfo, Vector3 customTargetPos, float size = 1f, int placementMode = 0, [Optional] Vector3 lookAxis, float lookAxisMaxDot = 1f)
			{
				return null;
			}

			// Token: 0x06000501 RID: 1281 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000501")]
			[Address(RVA = "0x2E16D90", Offset = "0x2E15390", VA = "0x182E16D90")]
			public TargetInfo GetTargetInfoClone(TargetInfo targetInfo)
			{
				return null;
			}

			// Token: 0x06000502 RID: 1282 RVA: 0x000042BC File Offset: 0x000024BC
			[Token(Token = "0x6000502")]
			[Address(RVA = "0x2E16E10", Offset = "0x2E15410", VA = "0x182E16E10")]
			private bool OutputSnapPointsToFile(string arg)
			{
				return default(bool);
			}

			// Token: 0x06000503 RID: 1283 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x2E178E0", Offset = "0x2E15EE0", VA = "0x182E178E0")]
			public PredictedSnapPointRepository()
			{
			}

			// Token: 0x04000457 RID: 1111
			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Header("Settings")]
			[SerializeField]
			private float _castOriginOffsetRatio;

			// Token: 0x04000458 RID: 1112
			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private ConstructionManager.PredictedSnapPointGrid _grid;

			// Token: 0x04000459 RID: 1113
			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private ConstructionManager.PredictedSnapPointsDebug _debug;

			// Token: 0x0400045E RID: 1118
			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3Int _lookingUpArea;

			// Token: 0x0400045F RID: 1119
			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private ConstructionManager.SnapPointLookupOperation _lookupOperation;

			// Token: 0x04000460 RID: 1120
			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private ConstructionManager.DirtyAreasOperation _dirtyAreasOperation;
		}

		// Token: 0x020000AE RID: 174
		[Token(Token = "0x20000AE")]
		[Serializable]
		public class PredictedSnapPointsDebug
		{
			// Token: 0x1700019C RID: 412
			// (get) Token: 0x06000504 RID: 1284 RVA: 0x000042D4 File Offset: 0x000024D4
			[Token(Token = "0x1700019C")]
			public bool ShowSnapPointsGizmos
			{
				[Token(Token = "0x6000504")]
				[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000505 RID: 1285 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			public void Init(ConstructionManager.PredictedSnapPointRepository predictedSnapPointRepository)
			{
			}

			// Token: 0x06000506 RID: 1286 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public void ShowDirtyAreaDebugInfo(Vector3Int area, Vector3 areaVolume)
			{
			}

			// Token: 0x06000507 RID: 1287 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x2E17B00", Offset = "0x2E16100", VA = "0x182E17B00")]
			public void ShowAreaDebugInfo(PredictedAreaData predictedTargets, Vector3Int area)
			{
			}

			// Token: 0x06000508 RID: 1288 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public void ShowSnapPointPositionDebugInfo(PredictedTarget predictedTarget)
			{
			}

			// Token: 0x06000509 RID: 1289 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x2E17B80", Offset = "0x2E16180", VA = "0x182E17B80")]
			public void ShowTargetSnapPointDebugInfo(PredictedTarget target, Vector3 castOrigin)
			{
			}

			// Token: 0x0600050A RID: 1290 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public PredictedSnapPointsDebug()
			{
			}

			// Token: 0x04000461 RID: 1121
			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private bool _showSnapPointsGizmos;

			// Token: 0x04000462 RID: 1122
			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[SerializeField]
			private bool _showAreasVolumeGizmos;

			// Token: 0x04000463 RID: 1123
			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			[SerializeField]
			private bool _showAreaInfoGizmos;

			// Token: 0x04000464 RID: 1124
			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[NonSerialized]
			private ConstructionManager.PredictedSnapPointRepository _repo;

			// Token: 0x04000465 RID: 1125
			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private StringBuilder _sb;
		}

		// Token: 0x020000AF RID: 175
		[Token(Token = "0x20000AF")]
		[Serializable]
		public class PredictedSnapPointsLookup
		{
			// Token: 0x1700019D RID: 413
			// (get) Token: 0x0600050B RID: 1291 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x0600050C RID: 1292 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700019D")]
			public ConstructionManager Manager
			{
				[Token(Token = "0x600050B")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600050C")]
				[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700019E RID: 414
			// (get) Token: 0x0600050D RID: 1293 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x0600050E RID: 1294 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700019E")]
			public ConstructionSystem System
			{
				[Token(Token = "0x600050D")]
				[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600050E")]
				[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700019F RID: 415
			// (get) Token: 0x0600050F RID: 1295 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x06000510 RID: 1296 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700019F")]
			public PhysicsCaster PhysicsCaster
			{
				[Token(Token = "0x600050F")]
				[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000510")]
				[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000511 RID: 1297 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x2E181B0", Offset = "0x2E167B0", VA = "0x182E181B0")]
			public void Init(ConstructionManager manager)
			{
			}

			// Token: 0x06000512 RID: 1298 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x2E18450", Offset = "0x2E16A50", VA = "0x182E18450")]
			public void LookupMissingGridAreas()
			{
			}

			// Token: 0x06000513 RID: 1299 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x2E18630", Offset = "0x2E16C30", VA = "0x182E18630")]
			private void LookupPredictedSnapPoints(ConstructionManager.PredictedSnapPointsLookup.AreaTargets areaTargets, List<ISnapPointPredictingModule> onStructurePredictingModules)
			{
			}

			// Token: 0x06000514 RID: 1300 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x2E18A40", Offset = "0x2E17040", VA = "0x182E18A40")]
			public ConstructionManager.PredictedSnapPointsLookup.AreaTargets GetAreaTargetsInstance(Vector3Int area)
			{
				return null;
			}

			// Token: 0x06000515 RID: 1301 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x2E18C00", Offset = "0x2E17200", VA = "0x182E18C00")]
			public PredictedSnapPointsLookup()
			{
			}

			// Token: 0x06000516 RID: 1302 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x2E18D30", Offset = "0x2E17330", VA = "0x182E18D30")]
			[CompilerGenerated]
			private void <LookupMissingGridAreas>g__LookupNearbyAreasTargets|15_0(ref ConstructionManager.PredictedSnapPointsLookup.<>c__DisplayClass15_0 A_1)
			{
			}

			// Token: 0x06000517 RID: 1303 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x2E18D90", Offset = "0x2E17390", VA = "0x182E18D90")]
			[CompilerGenerated]
			private void <LookupMissingGridAreas>g__ProcessFoundAreaTargets|15_1(ref ConstructionManager.PredictedSnapPointsLookup.<>c__DisplayClass15_0 A_1)
			{
			}

			// Token: 0x04000466 RID: 1126
			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Dictionary<Vector3Int, ConstructionManager.PredictedSnapPointsLookup.AreaTargets> _areaTargets;

			// Token: 0x0400046A RID: 1130
			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private ConstructionManager.LookupMissingGridAreasOperation _lookupMissingGridAreasOperation;

			// Token: 0x020000B0 RID: 176
			[Token(Token = "0x20000B0")]
			public class AreaTargets
			{
				// Token: 0x170001A0 RID: 416
				// (get) Token: 0x06000518 RID: 1304 RVA: 0x000042EC File Offset: 0x000024EC
				// (set) Token: 0x06000519 RID: 1305 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x170001A0")]
				public Vector3Int Area
				{
					[Token(Token = "0x6000518")]
					[Address(RVA = "0x1766460", Offset = "0x1764A60", VA = "0x181766460")]
					[CompilerGenerated]
					get
					{
						return default(Vector3Int);
					}
					[Token(Token = "0x6000519")]
					[Address(RVA = "0x2040020", Offset = "0x203E620", VA = "0x182040020")]
					[CompilerGenerated]
					set
					{
					}
				}

				// Token: 0x170001A1 RID: 417
				// (get) Token: 0x0600051A RID: 1306 RVA: 0x00002068 File Offset: 0x00000268
				[Token(Token = "0x170001A1")]
				public List<TargetInfo> Targets
				{
					[Token(Token = "0x600051A")]
					[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				// Token: 0x170001A2 RID: 418
				// (get) Token: 0x0600051B RID: 1307 RVA: 0x00002068 File Offset: 0x00000268
				[Token(Token = "0x170001A2")]
				public HashSet<Transform> AlreadyTargetedStructures
				{
					[Token(Token = "0x600051B")]
					[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
					[CompilerGenerated]
					get
					{
						return null;
					}
				}

				// Token: 0x0600051C RID: 1308 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x600051C")]
				[Address(RVA = "0x2E19200", Offset = "0x2E17800", VA = "0x182E19200")]
				public void Add(TargetInfo targetInfo)
				{
				}

				// Token: 0x0600051D RID: 1309 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x600051D")]
				[Address(RVA = "0x2E192A0", Offset = "0x2E178A0", VA = "0x182E192A0")]
				public void Dispose()
				{
				}

				// Token: 0x0600051E RID: 1310 RVA: 0x00002066 File Offset: 0x00000266
				[Token(Token = "0x600051E")]
				[Address(RVA = "0x2E19520", Offset = "0x2E17B20", VA = "0x182E19520")]
				public AreaTargets()
				{
				}
			}
		}

		// Token: 0x020000B2 RID: 178
		[Token(Token = "0x20000B2")]
		public class SnapPointLookupOperation : IAreaProcessor
		{
			// Token: 0x170001A3 RID: 419
			// (get) Token: 0x0600051F RID: 1311 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x06000520 RID: 1312 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170001A3")]
			public PredictedTarget Target
			{
				[Token(Token = "0x600051F")]
				[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000520")]
				[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000521 RID: 1313 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x2E19670", Offset = "0x2E17C70", VA = "0x182E19670")]
			public void Init(ConstructionManager.PredictedSnapPointRepository repository)
			{
			}

			// Token: 0x06000522 RID: 1314 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x2E198D0", Offset = "0x2E17ED0", VA = "0x182E198D0")]
			public void LookupOccludingStructureAndCalcMaxDistance()
			{
			}

			// Token: 0x06000523 RID: 1315 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x2E19AC0", Offset = "0x2E180C0", VA = "0x182E19AC0", Slot = "4")]
			private void ProcessArea(Vector3Int area)
			{
			}

			// Token: 0x06000524 RID: 1316 RVA: 0x00004304 File Offset: 0x00002504
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x2E19E10", Offset = "0x2E18410", VA = "0x182E19E10")]
			private bool TryFindPredictedTarget(List<PredictedTarget> targetList, bool validateHeldItem, out PredictedTarget target)
			{
				return default(bool);
			}

			// Token: 0x06000525 RID: 1317 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public SnapPointLookupOperation()
			{
			}

			// Token: 0x04000471 RID: 1137
			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private ConstructionManager.PredictedSnapPointRepository _repository;

			// Token: 0x04000472 RID: 1138
			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private ConstructionManager.ModuleStateManager _statesManager;

			// Token: 0x04000473 RID: 1139
			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private PhysicsCaster _physicsCaster;

			// Token: 0x04000474 RID: 1140
			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float _maxDistance;

			// Token: 0x04000475 RID: 1141
			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float _absoluteMaxDistance;

			// Token: 0x04000476 RID: 1142
			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Structure _occludingStructure;

			// Token: 0x04000477 RID: 1143
			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Vector3 _castOrigin;

			// Token: 0x04000478 RID: 1144
			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ItemData _heldItem;

			// Token: 0x04000479 RID: 1145
			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float _highestTargetScore;

			// Token: 0x0400047B RID: 1147
			[Token(Token = "0x400047B")]
			private const float MinDot = 0.9f;

			// Token: 0x0400047C RID: 1148
			[Token(Token = "0x400047C")]
			private const float MinDistance = 0.5f;

			// Token: 0x0400047D RID: 1149
			[Token(Token = "0x400047D")]
			private const float DistanceImportance = 0.1f;
		}

		// Token: 0x020000B3 RID: 179
		[Token(Token = "0x20000B3")]
		public class ActiveModuleInfo
		{
			// Token: 0x170001A4 RID: 420
			// (get) Token: 0x06000526 RID: 1318 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170001A4")]
			private ConstructionManager Manager
			{
				[Token(Token = "0x6000526")]
				[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170001A5 RID: 421
			// (get) Token: 0x06000527 RID: 1319 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170001A5")]
			private ConstructionSystem System
			{
				[Token(Token = "0x6000527")]
				[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170001A6 RID: 422
			// (get) Token: 0x06000528 RID: 1320 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170001A6")]
			private ConstructionManager.ModuleStateManager StateManager
			{
				[Token(Token = "0x6000528")]
				[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x06000529 RID: 1321 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x0600052A RID: 1322 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170001A7")]
			public IConstructionModule Module
			{
				[Token(Token = "0x6000529")]
				[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600052A")]
				[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600052B RID: 1323 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x2E1A7E0", Offset = "0x2E18DE0", VA = "0x182E1A7E0")]
			public ActiveModuleInfo(ConstructionManager manager)
			{
			}

			// Token: 0x0600052C RID: 1324 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x2E1A940", Offset = "0x2E18F40", VA = "0x182E1A940")]
			public void ActivateModule(IConstructionModule module)
			{
			}

			// Token: 0x0600052D RID: 1325 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x2E1ABA0", Offset = "0x2E191A0", VA = "0x182E1ABA0")]
			public void Reset()
			{
			}

			// Token: 0x0600052E RID: 1326 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x2E1ACC0", Offset = "0x2E192C0", VA = "0x182E1ACC0")]
			public void Update()
			{
			}

			// Token: 0x0600052F RID: 1327 RVA: 0x0000431C File Offset: 0x0000251C
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x2E1B030", Offset = "0x2E19630", VA = "0x182E1B030")]
			public bool IsPerformingAnimation()
			{
				return default(bool);
			}

			// Token: 0x06000530 RID: 1328 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x2E1B2B0", Offset = "0x2E198B0", VA = "0x182E1B2B0")]
			public void GrabPlayerPosition()
			{
			}

			// Token: 0x06000531 RID: 1329 RVA: 0x00004334 File Offset: 0x00002534
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x2E1B390", Offset = "0x2E19990", VA = "0x182E1B390")]
			private bool CheckDistanceBasedAutoCancelFailSafe()
			{
				return default(bool);
			}

			// Token: 0x06000532 RID: 1330 RVA: 0x0000434C File Offset: 0x0000254C
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x2E1B5B0", Offset = "0x2E19BB0", VA = "0x182E1B5B0")]
			public bool CheckMovementSpeedBasedAutoCancelFailSafe()
			{
				return default(bool);
			}

			// Token: 0x06000533 RID: 1331 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x2E1B6D0", Offset = "0x2E19CD0", VA = "0x182E1B6D0")]
			public void PlaceActionCompleted(bool resetAllAfter)
			{
			}

			// Token: 0x06000534 RID: 1332 RVA: 0x00004364 File Offset: 0x00002564
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x2E1C110", Offset = "0x2E1A710", VA = "0x182E1C110")]
			private bool TryBounceActiveModule()
			{
				return default(bool);
			}

			// Token: 0x06000535 RID: 1333 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x2E1C250", Offset = "0x2E1A850", VA = "0x182E1C250")]
			private IEnumerator DelayedResetAll()
			{
				return null;
			}

			// Token: 0x0400047E RID: 1150
			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private double _lastActivationTime;

			// Token: 0x0400047F RID: 1151
			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int _lastModuleId;

			// Token: 0x04000480 RID: 1152
			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Vector3 _moduleActivationPlayerPosition;
		}

		// Token: 0x020000B5 RID: 181
		[Token(Token = "0x20000B5")]
		public class BlockingRoutineManager
		{
			// Token: 0x0600053C RID: 1340 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			public BlockingRoutineManager(ConstructionManager manager)
			{
			}

			// Token: 0x170001AA RID: 426
			// (get) Token: 0x0600053D RID: 1341 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x0600053E RID: 1342 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170001AA")]
			public ConstructionManager Manager
			{
				[Token(Token = "0x600053D")]
				[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600053E")]
				[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170001AB RID: 427
			// (get) Token: 0x0600053F RID: 1343 RVA: 0x00004394 File Offset: 0x00002594
			[Token(Token = "0x170001AB")]
			public bool IsRunning
			{
				[Token(Token = "0x600053F")]
				[Address(RVA = "0x70BA10", Offset = "0x70A010", VA = "0x18070BA10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000540 RID: 1344 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x2E1C580", Offset = "0x2E1AB80", VA = "0x182E1C580")]
			public void RunBlocking(IEnumerator routine, [Optional] Action onCancelCallback, float killDelay = 3f)
			{
			}

			// Token: 0x06000541 RID: 1345 RVA: 0x000043AC File Offset: 0x000025AC
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x2E1C760", Offset = "0x2E1AD60", VA = "0x182E1C760")]
			public bool IsRunningBlockingRoutine()
			{
				return default(bool);
			}

			// Token: 0x06000542 RID: 1346 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x2E1C8C0", Offset = "0x2E1AEC0", VA = "0x182E1C8C0")]
			public void Reset()
			{
			}

			// Token: 0x06000543 RID: 1347 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x2E1C930", Offset = "0x2E1AF30", VA = "0x182E1C930")]
			[CompilerGenerated]
			private IEnumerator <RunBlocking>g__InternalRunner|10_0(IEnumerator r)
			{
				return null;
			}

			// Token: 0x04000489 RID: 1161
			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Coroutine _blockingRoutine;

			// Token: 0x0400048A RID: 1162
			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float _blockingRoutineKillTime;

			// Token: 0x0400048B RID: 1163
			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Action _onCancelBlockingRoutineCallback;
		}

		// Token: 0x020000B7 RID: 183
		[Token(Token = "0x20000B7")]
		public class ItemManager : IItemSource
		{
			// Token: 0x0600054A RID: 1354 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			public ItemManager(ConstructionManager manager)
			{
			}

			// Token: 0x170001AE RID: 430
			// (get) Token: 0x0600054B RID: 1355 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170001AE")]
			private ConstructionManager Manager
			{
				[Token(Token = "0x600054B")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170001AF RID: 431
			// (get) Token: 0x0600054C RID: 1356 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x0600054D RID: 1357 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170001AF")]
			public ItemData Held
			{
				[Token(Token = "0x600054C")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600054D")]
				[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170001B0 RID: 432
			// (get) Token: 0x0600054E RID: 1358 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x0600054F RID: 1359 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170001B0")]
			public ItemData LastConsumed
			{
				[Token(Token = "0x600054E")]
				[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600054F")]
				[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000550 RID: 1360 RVA: 0x000043DC File Offset: 0x000025DC
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x2E1CC40", Offset = "0x2E1B240", VA = "0x182E1CC40")]
			public bool TryEquip(ItemData item)
			{
				return default(bool);
			}

			// Token: 0x06000551 RID: 1361 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x2E1CF60", Offset = "0x2E1B560", VA = "0x182E1CF60")]
			public void CheckIfShouldEquipPrevious()
			{
			}

			// Token: 0x06000552 RID: 1362 RVA: 0x000043F4 File Offset: 0x000025F4
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x2E1CFC0", Offset = "0x2E1B5C0", VA = "0x182E1CFC0")]
			public bool CheckOwns(ItemData item)
			{
				return default(bool);
			}

			// Token: 0x06000553 RID: 1363 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x2E1D060", Offset = "0x2E1B660", VA = "0x182E1D060")]
			public void LookupHeld()
			{
			}

			// Token: 0x06000554 RID: 1364 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x6000554")]
			[Address(RVA = "0x2E1D080", Offset = "0x2E1B680", VA = "0x182E1D080", Slot = "4")]
			public ItemInstance GetCurrentItem()
			{
				return null;
			}

			// Token: 0x06000555 RID: 1365 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000555")]
			[Address(RVA = "0x2E1D200", Offset = "0x2E1B800", VA = "0x182E1D200")]
			public void LookupHeld(out bool changed)
			{
			}

			// Token: 0x06000556 RID: 1366 RVA: 0x0000440C File Offset: 0x0000260C
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x2E1D390", Offset = "0x2E1B990", VA = "0x182E1D390")]
			public bool ConsumeModuleProfileItem()
			{
				return default(bool);
			}

			// Token: 0x06000557 RID: 1367 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000557")]
			[Address(RVA = "0x2E1D6A0", Offset = "0x2E1BCA0", VA = "0x182E1D6A0")]
			public void AddOrDrop(ItemData item)
			{
			}

			// Token: 0x06000558 RID: 1368 RVA: 0x00004424 File Offset: 0x00002624
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x2D5F0F0", Offset = "0x2D5D6F0", VA = "0x182D5F0F0", Slot = "5")]
			public bool TryRemove(ItemInstance item)
			{
				return default(bool);
			}

			// Token: 0x06000559 RID: 1369 RVA: 0x0000443C File Offset: 0x0000263C
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x2D5F190", Offset = "0x2D5D790", VA = "0x182D5F190", Slot = "6")]
			public bool TryEquip(ItemInstance item)
			{
				return default(bool);
			}

			// Token: 0x04000494 RID: 1172
			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool _lastEquipChangedItem;
		}

		// Token: 0x020000B8 RID: 184
		[Token(Token = "0x20000B8")]
		[Serializable]
		public class ModuleStateManager
		{
			// Token: 0x170001B1 RID: 433
			// (get) Token: 0x0600055A RID: 1370 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170001B1")]
			public IReadOnlyList<ModuleState> States
			{
				[Token(Token = "0x600055A")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600055B RID: 1371 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x2E1D7D0", Offset = "0x2E1BDD0", VA = "0x182E1D7D0")]
			public void Init(ConstructionSystem constructionSystem)
			{
			}

			// Token: 0x0600055C RID: 1372 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x2E1D9E0", Offset = "0x2E1BFE0", VA = "0x182E1D9E0")]
			public ModuleState GetState(IConstructionModule module)
			{
				return null;
			}

			// Token: 0x0600055D RID: 1373 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x2E1DA80", Offset = "0x2E1C080", VA = "0x182E1DA80")]
			public ModuleStateManager()
			{
			}

			// Token: 0x04000495 RID: 1173
			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly List<ModuleState> _states;
		}

		// Token: 0x020000B9 RID: 185
		[Token(Token = "0x20000B9")]
		public class PlayerInfo
		{
			// Token: 0x170001B2 RID: 434
			// (get) Token: 0x0600055E RID: 1374 RVA: 0x00004454 File Offset: 0x00002654
			[Token(Token = "0x170001B2")]
			public bool IsInMidAction
			{
				[Token(Token = "0x600055E")]
				[Address(RVA = "0x2E1DB30", Offset = "0x2E1C130", VA = "0x182E1DB30")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600055F RID: 1375 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600055F")]
			[Address(RVA = "0x2E1DB40", Offset = "0x2E1C140", VA = "0x182E1DB40")]
			public void SetIsInMidAction(bool value)
			{
			}

			// Token: 0x170001B3 RID: 435
			// (get) Token: 0x06000560 RID: 1376 RVA: 0x0000446C File Offset: 0x0000266C
			[Token(Token = "0x170001B3")]
			public bool IsRunning
			{
				[Token(Token = "0x6000560")]
				[Address(RVA = "0x2E1DBA0", Offset = "0x2E1C1A0", VA = "0x182E1DBA0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170001B4 RID: 436
			// (get) Token: 0x06000561 RID: 1377 RVA: 0x00004484 File Offset: 0x00002684
			[Token(Token = "0x170001B4")]
			public bool IsMoving
			{
				[Token(Token = "0x6000561")]
				[Address(RVA = "0x2E1DC70", Offset = "0x2E1C270", VA = "0x182E1DC70")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170001B5 RID: 437
			// (get) Token: 0x06000562 RID: 1378 RVA: 0x0000449C File Offset: 0x0000269C
			[Token(Token = "0x170001B5")]
			public bool IsInCave
			{
				[Token(Token = "0x6000562")]
				[Address(RVA = "0x2E1DD40", Offset = "0x2E1C340", VA = "0x182E1DD40")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170001B6 RID: 438
			// (get) Token: 0x06000563 RID: 1379 RVA: 0x000044B4 File Offset: 0x000026B4
			[Token(Token = "0x170001B6")]
			public bool AllowConstructions
			{
				[Token(Token = "0x6000563")]
				[Address(RVA = "0x2E1DD80", Offset = "0x2E1C380", VA = "0x182E1DD80")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170001B7 RID: 439
			// (get) Token: 0x06000564 RID: 1380 RVA: 0x000044CC File Offset: 0x000026CC
			[Token(Token = "0x170001B7")]
			public bool BlockFullBodyInteraction
			{
				[Token(Token = "0x6000564")]
				[Address(RVA = "0x2E1DDC0", Offset = "0x2E1C3C0", VA = "0x182E1DDC0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170001B8 RID: 440
			// (get) Token: 0x06000565 RID: 1381 RVA: 0x000044E4 File Offset: 0x000026E4
			[Token(Token = "0x170001B8")]
			public bool IsFacingEnemies
			{
				[Token(Token = "0x6000565")]
				[Address(RVA = "0x2E1DDD0", Offset = "0x2E1C3D0", VA = "0x182E1DDD0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000566 RID: 1382 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x2E1DE60", Offset = "0x2E1C460", VA = "0x182E1DE60")]
			public void OnSwitchPlacementMode()
			{
			}

			// Token: 0x06000567 RID: 1383 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000567")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public PlayerInfo()
			{
			}
		}

		// Token: 0x020000BA RID: 186
		[Token(Token = "0x20000BA")]
		public class StagedModuleInfo
		{
			// Token: 0x06000568 RID: 1384 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x2E1DEB0", Offset = "0x2E1C4B0", VA = "0x182E1DEB0")]
			public StagedModuleInfo(ConstructionManager manager)
			{
			}

			// Token: 0x170001B9 RID: 441
			// (get) Token: 0x06000569 RID: 1385 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170001B9")]
			private ConstructionManager Manager
			{
				[Token(Token = "0x6000569")]
				[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170001BA RID: 442
			// (get) Token: 0x0600056A RID: 1386 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x170001BA")]
			private ConstructionManager.ModuleStateManager StateManager
			{
				[Token(Token = "0x600056A")]
				[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170001BB RID: 443
			// (get) Token: 0x0600056B RID: 1387 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x0600056C RID: 1388 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170001BB")]
			public IConstructionModule Module
			{
				[Token(Token = "0x600056B")]
				[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600056C")]
				[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170001BC RID: 444
			// (get) Token: 0x0600056D RID: 1389 RVA: 0x00002068 File Offset: 0x00000268
			// (set) Token: 0x0600056E RID: 1390 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170001BC")]
			public ModuleProfile Profile
			{
				[Token(Token = "0x600056D")]
				[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600056E")]
				[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600056F RID: 1391 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600056F")]
			[Address(RVA = "0x2E1DF90", Offset = "0x2E1C590", VA = "0x182E1DF90")]
			public void StageModule(IConstructionModule module, ModuleProfile profile)
			{
			}

			// Token: 0x06000570 RID: 1392 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x2E1E4E0", Offset = "0x2E1CAE0", VA = "0x182E1E4E0")]
			public void Reset()
			{
			}

			// Token: 0x06000571 RID: 1393 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000571")]
			[Address(RVA = "0x2E1E6F0", Offset = "0x2E1CCF0", VA = "0x182E1E6F0")]
			private void UpdatePlayerState()
			{
			}

			// Token: 0x04000496 RID: 1174
			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private TargetInfo _targetInfo;

			// Token: 0x04000497 RID: 1175
			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private StructureElement _targetElement;

			// Token: 0x04000498 RID: 1176
			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int _placementMode;
		}
	}
}
