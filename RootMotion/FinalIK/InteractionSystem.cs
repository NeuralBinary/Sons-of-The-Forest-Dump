using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace RootMotion.FinalIK
{
	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	public class InteractionSystem : MonoBehaviour
	{
		// Token: 0x060004DC RID: 1244 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x2978CF0", Offset = "0x29772F0", VA = "0x182978CF0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x2978D80", Offset = "0x2977380", VA = "0x182978D80")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x2978E10", Offset = "0x2977410", VA = "0x182978E10")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x2978EA0", Offset = "0x29774A0", VA = "0x182978EA0")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x2978F30", Offset = "0x2977530", VA = "0x182978F30")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x2978FC0", Offset = "0x29775C0", VA = "0x182978FC0")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x2979050", Offset = "0x2977650", VA = "0x182979050")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x29790E0", Offset = "0x29776E0", VA = "0x1829790E0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x00003E9C File Offset: 0x0000209C
		[Token(Token = "0x1700008A")]
		public bool inInteraction
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x2979170", Offset = "0x2977770", VA = "0x182979170")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00003EB4 File Offset: 0x000020B4
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x2979250", Offset = "0x2977850", VA = "0x182979250")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00003ECC File Offset: 0x000020CC
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x2979330", Offset = "0x2977930", VA = "0x182979330")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00003EE4 File Offset: 0x000020E4
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x2979410", Offset = "0x2977A10", VA = "0x182979410")]
		public bool IsPaused()
		{
			return default(bool);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00003EFC File Offset: 0x000020FC
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x29794F0", Offset = "0x2977AF0", VA = "0x1829794F0")]
		public bool IsInSync()
		{
			return default(bool);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00003F14 File Offset: 0x00002114
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x2979610", Offset = "0x2977C10", VA = "0x182979610")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00003F2C File Offset: 0x0000212C
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x2979780", Offset = "0x2977D80", VA = "0x182979780")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00003F44 File Offset: 0x00002144
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x2979820", Offset = "0x2977E20", VA = "0x182979820")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00003F5C File Offset: 0x0000215C
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x29798C0", Offset = "0x2977EC0", VA = "0x1829798C0")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x2979960", Offset = "0x2977F60", VA = "0x182979960")]
		public void PauseAll()
		{
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x29799E0", Offset = "0x2977FE0", VA = "0x1829799E0")]
		public void ResumeAll()
		{
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x2979AB0", Offset = "0x29780B0", VA = "0x182979AB0")]
		public void StopAll()
		{
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x2979B30", Offset = "0x2978130", VA = "0x182979B30")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00003F74 File Offset: 0x00002174
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x2979BC0", Offset = "0x29781C0", VA = "0x182979BC0")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return 0f;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00003F8C File Offset: 0x0000218C
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x2979C80", Offset = "0x2978280", VA = "0x182979C80")]
		public float GetMinActiveProgress()
		{
			return 0f;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00003FA4 File Offset: 0x000021A4
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x2979DB0", Offset = "0x29783B0", VA = "0x182979DB0")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00003FBC File Offset: 0x000021BC
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x2979FC0", Offset = "0x29785C0", VA = "0x182979FC0")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00003FD4 File Offset: 0x000021D4
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x297A240", Offset = "0x2978840", VA = "0x18297A240")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x297A5E0", Offset = "0x2978BE0", VA = "0x18297A5E0")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x297A6C0", Offset = "0x2978CC0", VA = "0x18297A6C0")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x297A710", Offset = "0x2978D10", VA = "0x18297A710")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x297A790", Offset = "0x2978D90", VA = "0x18297A790")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x297A990", Offset = "0x2978F90", VA = "0x18297A990")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00003FEC File Offset: 0x000021EC
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x297AB70", Offset = "0x2979170", VA = "0x18297AB70")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x297AEA0", Offset = "0x29794A0", VA = "0x18297AEA0")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00004004 File Offset: 0x00002204
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x297B010", Offset = "0x2979610", VA = "0x18297B010")]
		public int GetClosestTriggerIndex()
		{
			return 0;
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008B")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x7849C0", Offset = "0x782FC0", VA = "0x1807849C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x7849D0", Offset = "0x782FD0", VA = "0x1807849D0")]
			set
			{
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008C")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000501")]
			[Address(RVA = "0x661080", Offset = "0x65F680", VA = "0x180661080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x297B300", Offset = "0x2979900", VA = "0x18297B300")]
		public void Start()
		{
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x297BD30", Offset = "0x297A330", VA = "0x18297BD30")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x297BD50", Offset = "0x297A350", VA = "0x18297BD50")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x297BD50", Offset = "0x297A350", VA = "0x18297BD50")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x297BD70", Offset = "0x297A370", VA = "0x18297BD70")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x297BF00", Offset = "0x297A500", VA = "0x18297BF00")]
		public void OnTriggerEnter(Collider c)
		{
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x297C110", Offset = "0x297A710", VA = "0x18297C110")]
		public void OnTriggerExit(Collider c)
		{
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0000401C File Offset: 0x0000221C
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x297C2C0", Offset = "0x297A8C0", VA = "0x18297C2C0")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x297C530", Offset = "0x297AB30", VA = "0x18297C530")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x297C7F0", Offset = "0x297ADF0", VA = "0x18297C7F0")]
		public void Update()
		{
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x297CB40", Offset = "0x297B140", VA = "0x18297CB40")]
		private void Raycasting()
		{
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x297CD90", Offset = "0x297B390", VA = "0x18297CD90")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x297D4B0", Offset = "0x297BAB0", VA = "0x18297D4B0")]
		private void UpdateEffectors()
		{
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x297D6A0", Offset = "0x297BCA0", VA = "0x18297D6A0")]
		private void OnPreFBBIK()
		{
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x297D8F0", Offset = "0x297BEF0", VA = "0x18297D8F0")]
		private void OnPostFBBIK()
		{
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x297DBB0", Offset = "0x297C1B0", VA = "0x18297DBB0")]
		private void OnFixTransforms()
		{
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x297DCB0", Offset = "0x297C2B0", VA = "0x18297DCB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00004034 File Offset: 0x00002234
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x297E430", Offset = "0x297CA30", VA = "0x18297E430")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0000404C File Offset: 0x0000224C
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x297E5B0", Offset = "0x297CBB0", VA = "0x18297E5B0")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x297E770", Offset = "0x297CD70", VA = "0x18297E770")]
		public InteractionSystem()
		{
		}

		// Token: 0x0400047B RID: 1147
		[Token(Token = "0x400047B")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag;

		// Token: 0x0400047C RID: 1148
		[Token(Token = "0x400047C")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime;

		// Token: 0x0400047D RID: 1149
		[Token(Token = "0x400047D")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("The master speed for all interactions.")]
		public float speed;

		// Token: 0x0400047E RID: 1150
		[Token(Token = "0x400047E")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed;

		// Token: 0x0400047F RID: 1151
		[Token(Token = "0x400047F")]
		[FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("collider")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		[Header("Triggering")]
		public Collider characterCollider;

		// Token: 0x04000480 RID: 1152
		[Token(Token = "0x4000480")]
		[FieldOffset(Offset = "0x40")]
		[FormerlySerializedAs("camera")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		public Transform FPSCamera;

		// Token: 0x04000481 RID: 1153
		[Token(Token = "0x4000481")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance;

		// Token: 0x04000484 RID: 1156
		[Token(Token = "0x4000484")]
		[FieldOffset(Offset = "0x58")]
		private List<InteractionTrigger> inContact;

		// Token: 0x04000485 RID: 1157
		[Token(Token = "0x4000485")]
		[FieldOffset(Offset = "0x60")]
		private List<int> bestRangeIndexes;

		// Token: 0x04000486 RID: 1158
		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x68")]
		public InteractionSystem.InteractionDelegate OnInteractionStart;

		// Token: 0x04000487 RID: 1159
		[Token(Token = "0x4000487")]
		[FieldOffset(Offset = "0x70")]
		public InteractionSystem.InteractionDelegate OnInteractionPause;

		// Token: 0x04000488 RID: 1160
		[Token(Token = "0x4000488")]
		[FieldOffset(Offset = "0x78")]
		public InteractionSystem.InteractionDelegate OnInteractionPickUp;

		// Token: 0x04000489 RID: 1161
		[Token(Token = "0x4000489")]
		[FieldOffset(Offset = "0x80")]
		public InteractionSystem.InteractionDelegate OnInteractionResume;

		// Token: 0x0400048A RID: 1162
		[Token(Token = "0x400048A")]
		[FieldOffset(Offset = "0x88")]
		public InteractionSystem.InteractionDelegate OnInteractionStop;

		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0x90")]
		public InteractionSystem.InteractionEventDelegate OnInteractionEvent;

		// Token: 0x0400048C RID: 1164
		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0x98")]
		public RaycastHit raycastHit;

		// Token: 0x0400048D RID: 1165
		[Token(Token = "0x400048D")]
		[FieldOffset(Offset = "0xC8")]
		[Space(10f)]
		[Tooltip("Reference to the FBBIK component.")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		// Token: 0x0400048E RID: 1166
		[Token(Token = "0x400048E")]
		[FieldOffset(Offset = "0xD0")]
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt;

		// Token: 0x0400048F RID: 1167
		[Token(Token = "0x400048F")]
		[FieldOffset(Offset = "0xD8")]
		private InteractionEffector[] interactionEffectors;

		// Token: 0x04000490 RID: 1168
		[Token(Token = "0x4000490")]
		[FieldOffset(Offset = "0xE0")]
		private bool initiated;

		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0xE8")]
		private Collider lastCollider;

		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0xF0")]
		private Collider c;

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x06000517 RID: 1303
		[Token(Token = "0x200008C")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x0600051B RID: 1307
		[Token(Token = "0x200008D")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);
	}
}
