using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000649 RID: 1609
	[Token(Token = "0x2000649")]
	public class FootstepManager : MonoBehaviour
	{
		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x0600295F RID: 10591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000565")]
		public static FootstepManager Instance
		{
			[Token(Token = "0x600295F")]
			[Address(RVA = "0x2DCCD20", Offset = "0x2DCBD20", VA = "0x182DCCD20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002960")]
		[Address(RVA = "0x2DCB390", Offset = "0x2DCA390", VA = "0x182DCB390")]
		public static string GetEventPathIfExists(string path)
		{
			return null;
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002961")]
		[Address(RVA = "0x2DCAA20", Offset = "0x2DC9A20", VA = "0x182DCAA20")]
		protected internal void Awake()
		{
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002962")]
		[Address(RVA = "0x2DCC6E0", Offset = "0x2DCB6E0", VA = "0x182DCC6E0")]
		private void Start()
		{
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002963")]
		[Address(RVA = "0x2DCB330", Offset = "0x2DCA330", VA = "0x182DCB330")]
		private FootstepManager.IFootstepList GetDataForType(FootstepManager.FootstepClassType classType)
		{
			return null;
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002964")]
		[Address(RVA = "0x2DCC1C0", Offset = "0x2DCB1C0", VA = "0x182DCC1C0")]
		private void PreloadEvents()
		{
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002965")]
		[Address(RVA = "0x2DCB5C0", Offset = "0x2DCA5C0", VA = "0x182DCB5C0")]
		private void OnApplicationQuit()
		{
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002966")]
		[Address(RVA = "0x2DCB5D0", Offset = "0x2DCA5D0", VA = "0x182DCB5D0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x0000BF10 File Offset: 0x0000A110
		[Token(Token = "0x6002967")]
		[Address(RVA = "0x2DCC220", Offset = "0x2DCB220", VA = "0x182DCC220")]
		private bool ShouldPlay(Vector3 position)
		{
			return default(bool);
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002968")]
		[Address(RVA = "0x2DCB640", Offset = "0x2DCA640", VA = "0x182DCB640")]
		public void PlayerFootstepForPosition(Vector3 position, UnderfootSurfaceDetector.SurfaceType surfaceType, bool isOnGore, float speed, bool inWater, float waterDepth)
		{
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002969")]
		[Address(RVA = "0x2DCBD60", Offset = "0x2DCAD60", VA = "0x182DCBD60")]
		public void PlayerLandForPosition(Vector3 position, UnderfootSurfaceDetector.SurfaceType surfaceType, bool isOnGore, bool inWater, float waterDepth, bool networked)
		{
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296A")]
		[Address(RVA = "0x2DCAB00", Offset = "0x2DC9B00", VA = "0x182DCAB00")]
		public void GenericFootstepForPosition(Vector3 position, FootstepManager.FootstepClassType classType, FootstepManager.SoundType soundType, [Optional] VailActor actorSource)
		{
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x0000BF28 File Offset: 0x0000A128
		[Token(Token = "0x600296B")]
		[Address(RVA = "0x2DCC770", Offset = "0x2DCB770", VA = "0x182DCC770")]
		private UnderfootSurfaceDetector.SurfaceType TraceUnderfootSurface(Vector3 footPos, out float snowDepth)
		{
			return default(UnderfootSurfaceDetector.SurfaceType);
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x0000BF40 File Offset: 0x0000A140
		[Token(Token = "0x600296C")]
		[Address(RVA = "0x2DCB450", Offset = "0x2DCA450", VA = "0x182DCB450")]
		private VailAudioManager.Noise GetNoiseStimuli(FootstepManager.SoundType soundType)
		{
			return default(VailAudioManager.Noise);
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x0000BF58 File Offset: 0x0000A158
		[Token(Token = "0x600296D")]
		[Address(RVA = "0x2DCB480", Offset = "0x2DCA480", VA = "0x182DCB480")]
		private UnderfootSurfaceDetector.SurfaceType GetUnderfootSurface(Vector3 position, bool inWater, float snowDepth)
		{
			return default(UnderfootSurfaceDetector.SurfaceType);
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296E")]
		[Address(RVA = "0x1C1AA40", Offset = "0x1C19A40", VA = "0x181C1AA40")]
		public void ToggleDebug()
		{
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600296F")]
		[Address(RVA = "0x2DCC480", Offset = "0x2DCB480", VA = "0x182DCC480")]
		public static Transform SpawnFootstepEffect(GameObject spawnPrefab, Vector3 spawnPos, Quaternion spawnRot, float lifeSpan = 5f)
		{
			return null;
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002970")]
		[Address(RVA = "0x2DCC2A0", Offset = "0x2DCB2A0", VA = "0x182DCC2A0")]
		private Transform SpawnFootstepEffectInternal(GameObject spawnPrefab, Vector3 spawnPos, Quaternion spawnRot, float lifeSpan)
		{
			return null;
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002971")]
		[Address(RVA = "0x2DCCB10", Offset = "0x2DCBB10", VA = "0x182DCCB10")]
		public FootstepManager()
		{
		}

		// Token: 0x040024EE RID: 9454
		[Token(Token = "0x40024EE")]
		[FieldOffset(Offset = "0x20")]
		private readonly LayerMask _traceGroundMask;

		// Token: 0x040024EF RID: 9455
		[Token(Token = "0x40024EF")]
		[FieldOffset(Offset = "0x24")]
		private readonly LayerMask _terrainLayerMask;

		// Token: 0x040024F0 RID: 9456
		[Token(Token = "0x40024F0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FootstepManager.PlayerFootstepList _player;

		// Token: 0x040024F1 RID: 9457
		[Token(Token = "0x40024F1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FootstepEventList _mutantRegular;

		// Token: 0x040024F2 RID: 9458
		[Token(Token = "0x40024F2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FootstepEventList _mutantHeavy;

		// Token: 0x040024F3 RID: 9459
		[Token(Token = "0x40024F3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private FootstepEventList _virginia;

		// Token: 0x040024F4 RID: 9460
		[Token(Token = "0x40024F4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FootstepEventList _twins;

		// Token: 0x040024F5 RID: 9461
		[Token(Token = "0x40024F5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private FootstepEventList _demon;

		// Token: 0x040024F6 RID: 9462
		[Token(Token = "0x40024F6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UnderfootSurfaceDetector.SurfaceType[] _terrainTexSurfaceTypes;

		// Token: 0x040024F7 RID: 9463
		[Token(Token = "0x40024F7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private VailAudioManager.Noise _walkStepStimuli;

		// Token: 0x040024F8 RID: 9464
		[Token(Token = "0x40024F8")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private VailAudioManager.Noise _runStepStimuli;

		// Token: 0x040024F9 RID: 9465
		[Token(Token = "0x40024F9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private VailAudioManager.Noise _landStimuli;

		// Token: 0x040024FA RID: 9466
		[Token(Token = "0x40024FA")]
		[FieldOffset(Offset = "0x6C")]
		[Tooltip("step must be within this distance of local player to play audio")]
		[SerializeField]
		private float _playStepMaxDist;

		// Token: 0x040024FB RID: 9467
		[Token(Token = "0x40024FB")]
		[FieldOffset(Offset = "0x70")]
		private float _playLandMaxDist;

		// Token: 0x040024FC RID: 9468
		[Token(Token = "0x40024FC")]
		[FieldOffset(Offset = "0x74")]
		private float _minSnowDepth;

		// Token: 0x040024FD RID: 9469
		[Token(Token = "0x40024FD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _debugLog;

		// Token: 0x040024FE RID: 9470
		[Token(Token = "0x40024FE")]
		[FieldOffset(Offset = "0x79")]
		[SerializeField]
		private bool _debugTraces;

		// Token: 0x040024FF RID: 9471
		[Token(Token = "0x40024FF")]
		[FieldOffset(Offset = "0x7A")]
		private bool _hasPreloaded;

		// Token: 0x04002500 RID: 9472
		[Token(Token = "0x4002500")]
		[FieldOffset(Offset = "0x7B")]
		private bool _isApplicationQuitting;

		// Token: 0x04002501 RID: 9473
		[Token(Token = "0x4002501")]
		[FieldOffset(Offset = "0x0")]
		private static FootstepManager _instance;

		// Token: 0x04002502 RID: 9474
		[Token(Token = "0x4002502")]
		private const string ParticlePool = "Particles";

		// Token: 0x0200064A RID: 1610
		[Token(Token = "0x200064A")]
		public enum FootstepClassType
		{
			// Token: 0x04002504 RID: 9476
			[Token(Token = "0x4002504")]
			Player,
			// Token: 0x04002505 RID: 9477
			[Token(Token = "0x4002505")]
			MutantRegular,
			// Token: 0x04002506 RID: 9478
			[Token(Token = "0x4002506")]
			MutantHeavy,
			// Token: 0x04002507 RID: 9479
			[Token(Token = "0x4002507")]
			Virginia,
			// Token: 0x04002508 RID: 9480
			[Token(Token = "0x4002508")]
			Twins,
			// Token: 0x04002509 RID: 9481
			[Token(Token = "0x4002509")]
			Demon
		}

		// Token: 0x0200064B RID: 1611
		[Token(Token = "0x200064B")]
		public enum SoundType
		{
			// Token: 0x0400250B RID: 9483
			[Token(Token = "0x400250B")]
			Step,
			// Token: 0x0400250C RID: 9484
			[Token(Token = "0x400250C")]
			WalkStep,
			// Token: 0x0400250D RID: 9485
			[Token(Token = "0x400250D")]
			RunStep,
			// Token: 0x0400250E RID: 9486
			[Token(Token = "0x400250E")]
			SneakStep,
			// Token: 0x0400250F RID: 9487
			[Token(Token = "0x400250F")]
			Land
		}

		// Token: 0x0200064C RID: 1612
		[Token(Token = "0x200064C")]
		public interface IFootstepMaterial
		{
			// Token: 0x06002972 RID: 10610
			[Token(Token = "0x6002972")]
			void SetToDefaults(string prefix, string prefixLand);

			// Token: 0x06002973 RID: 10611
			[Token(Token = "0x6002973")]
			void PreloadEvents();

			// Token: 0x06002974 RID: 10612
			[Token(Token = "0x6002974")]
			void UnloadEvents();

			// Token: 0x06002975 RID: 10613
			[Token(Token = "0x6002975")]
			string GetEvent(FootstepManager.SoundType soundType);
		}

		// Token: 0x0200064D RID: 1613
		[Token(Token = "0x200064D")]
		[Serializable]
		public class PlayerFootstepMaterial : FootstepManager.IFootstepMaterial
		{
			// Token: 0x06002976 RID: 10614 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002976")]
			[Address(RVA = "0x65CA90", Offset = "0x65BA90", VA = "0x18065CA90")]
			public PlayerFootstepMaterial(string inDefaultDefaultPrefix)
			{
			}

			// Token: 0x06002977 RID: 10615 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002977")]
			[Address(RVA = "0x2DDB4C0", Offset = "0x2DDA4C0", VA = "0x182DDB4C0", Slot = "4")]
			public void SetToDefaults(string prefixStep, string prefixLand)
			{
			}

			// Token: 0x06002978 RID: 10616 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002978")]
			[Address(RVA = "0x2DDB410", Offset = "0x2DDA410", VA = "0x182DDB410", Slot = "5")]
			public void PreloadEvents()
			{
			}

			// Token: 0x06002979 RID: 10617 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002979")]
			[Address(RVA = "0x2DDB570", Offset = "0x2DDA570", VA = "0x182DDB570", Slot = "6")]
			public void UnloadEvents()
			{
			}

			// Token: 0x0600297A RID: 10618 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600297A")]
			[Address(RVA = "0x2DDB400", Offset = "0x2DDA400", VA = "0x182DDB400", Slot = "7")]
			public string GetEvent(FootstepManager.SoundType type)
			{
				return null;
			}

			// Token: 0x04002510 RID: 9488
			[Token(Token = "0x4002510")]
			[FieldOffset(Offset = "0x10")]
			[EventRef]
			public string StepEvent;

			// Token: 0x04002511 RID: 9489
			[Token(Token = "0x4002511")]
			[FieldOffset(Offset = "0x18")]
			[EventRef]
			public string LandEvent;

			// Token: 0x04002512 RID: 9490
			[Token(Token = "0x4002512")]
			[FieldOffset(Offset = "0x20")]
			[HideInInspector]
			public string DefaultPrefix;
		}

		// Token: 0x0200064E RID: 1614
		[Token(Token = "0x200064E")]
		[Serializable]
		public class MutantFootstepMaterial : FootstepManager.IFootstepMaterial
		{
			// Token: 0x0600297B RID: 10619 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600297B")]
			[Address(RVA = "0x2DD3D50", Offset = "0x2DD2D50", VA = "0x182DD3D50")]
			public MutantFootstepMaterial(string inDefaultDefaultPrefix)
			{
			}

			// Token: 0x0600297C RID: 10620 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600297C")]
			[Address(RVA = "0x2DD3980", Offset = "0x2DD2980", VA = "0x182DD3980", Slot = "4")]
			public void SetToDefaults(string prefixStep, string prefixLand)
			{
			}

			// Token: 0x0600297D RID: 10621 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600297D")]
			[Address(RVA = "0x2DD3740", Offset = "0x2DD2740", VA = "0x182DD3740", Slot = "7")]
			public string GetEvent(FootstepManager.SoundType type)
			{
				return null;
			}

			// Token: 0x0600297E RID: 10622 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600297E")]
			[Address(RVA = "0x2DD37D0", Offset = "0x2DD27D0", VA = "0x182DD37D0", Slot = "5")]
			public void PreloadEvents()
			{
			}

			// Token: 0x0600297F RID: 10623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600297F")]
			[Address(RVA = "0x2DD3C80", Offset = "0x2DD2C80", VA = "0x182DD3C80", Slot = "6")]
			public void UnloadEvents()
			{
			}

			// Token: 0x04002513 RID: 9491
			[Token(Token = "0x4002513")]
			[FieldOffset(Offset = "0x10")]
			[EventRef]
			public string SneakEvent;

			// Token: 0x04002514 RID: 9492
			[Token(Token = "0x4002514")]
			[FieldOffset(Offset = "0x18")]
			[EventRef]
			public string WalkEvent;

			// Token: 0x04002515 RID: 9493
			[Token(Token = "0x4002515")]
			[FieldOffset(Offset = "0x20")]
			[EventRef]
			public string RunEvent;

			// Token: 0x04002516 RID: 9494
			[Token(Token = "0x4002516")]
			[FieldOffset(Offset = "0x28")]
			[EventRef]
			public string LandEvent;

			// Token: 0x04002517 RID: 9495
			[Token(Token = "0x4002517")]
			[FieldOffset(Offset = "0x30")]
			[HideInInspector]
			public string DefaultPrefix;
		}

		// Token: 0x0200064F RID: 1615
		[Token(Token = "0x200064F")]
		public interface IFootstepList
		{
			// Token: 0x06002980 RID: 10624
			[Token(Token = "0x6002980")]
			void PreloadEvents();

			// Token: 0x06002981 RID: 10625
			[Token(Token = "0x6002981")]
			void UnloadEvents();

			// Token: 0x06002982 RID: 10626
			[Token(Token = "0x6002982")]
			string GetEvent(UnderfootSurfaceDetector.SurfaceType surface, FootstepManager.SoundType type);
		}

		// Token: 0x02000650 RID: 1616
		[Token(Token = "0x2000650")]
		[Serializable]
		public class PlayerFootstepList : FootstepManager.IFootstepList
		{
			// Token: 0x06002983 RID: 10627 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002983")]
			[Address(RVA = "0x2DDA940", Offset = "0x2DD9940", VA = "0x182DDA940", Slot = "4")]
			public void PreloadEvents()
			{
			}

			// Token: 0x06002984 RID: 10628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002984")]
			[Address(RVA = "0x2DDAB00", Offset = "0x2DD9B00", VA = "0x182DDAB00", Slot = "5")]
			public void UnloadEvents()
			{
			}

			// Token: 0x06002985 RID: 10629 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002985")]
			[Address(RVA = "0x2DDA7F0", Offset = "0x2DD97F0", VA = "0x182DDA7F0", Slot = "6")]
			public string GetEvent(UnderfootSurfaceDetector.SurfaceType surface, FootstepManager.SoundType type)
			{
				return null;
			}

			// Token: 0x06002986 RID: 10630 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002986")]
			[Address(RVA = "0x2DDACC0", Offset = "0x2DD9CC0", VA = "0x182DDACC0")]
			public PlayerFootstepList()
			{
			}

			// Token: 0x04002518 RID: 9496
			[Token(Token = "0x4002518")]
			[FieldOffset(Offset = "0x10")]
			public FootstepManager.PlayerFootstepMaterial Default;

			// Token: 0x04002519 RID: 9497
			[Token(Token = "0x4002519")]
			[FieldOffset(Offset = "0x18")]
			public FootstepManager.PlayerFootstepMaterial Sand;

			// Token: 0x0400251A RID: 9498
			[Token(Token = "0x400251A")]
			[FieldOffset(Offset = "0x20")]
			public FootstepManager.PlayerFootstepMaterial Mud;

			// Token: 0x0400251B RID: 9499
			[Token(Token = "0x400251B")]
			[FieldOffset(Offset = "0x28")]
			public FootstepManager.PlayerFootstepMaterial Leaves;

			// Token: 0x0400251C RID: 9500
			[Token(Token = "0x400251C")]
			[FieldOffset(Offset = "0x30")]
			public FootstepManager.PlayerFootstepMaterial Rock;

			// Token: 0x0400251D RID: 9501
			[Token(Token = "0x400251D")]
			[FieldOffset(Offset = "0x38")]
			public FootstepManager.PlayerFootstepMaterial Snow;

			// Token: 0x0400251E RID: 9502
			[Token(Token = "0x400251E")]
			[FieldOffset(Offset = "0x40")]
			public FootstepManager.PlayerFootstepMaterial Wood;

			// Token: 0x0400251F RID: 9503
			[Token(Token = "0x400251F")]
			[FieldOffset(Offset = "0x48")]
			public FootstepManager.PlayerFootstepMaterial Metal;

			// Token: 0x04002520 RID: 9504
			[Token(Token = "0x4002520")]
			[FieldOffset(Offset = "0x50")]
			public FootstepManager.PlayerFootstepMaterial MetalGrate;

			// Token: 0x04002521 RID: 9505
			[Token(Token = "0x4002521")]
			[FieldOffset(Offset = "0x58")]
			public FootstepManager.PlayerFootstepMaterial Carpet;

			// Token: 0x04002522 RID: 9506
			[Token(Token = "0x4002522")]
			[FieldOffset(Offset = "0x60")]
			public FootstepManager.PlayerFootstepMaterial Plastic;

			// Token: 0x04002523 RID: 9507
			[Token(Token = "0x4002523")]
			[FieldOffset(Offset = "0x68")]
			public FootstepManager.PlayerFootstepMaterial PlasticBed;

			// Token: 0x04002524 RID: 9508
			[Token(Token = "0x4002524")]
			[FieldOffset(Offset = "0x70")]
			public FootstepManager.PlayerFootstepMaterial BrokenGlass;

			// Token: 0x04002525 RID: 9509
			[Token(Token = "0x4002525")]
			[FieldOffset(Offset = "0x78")]
			public FootstepManager.PlayerFootstepMaterial Water;

			// Token: 0x04002526 RID: 9510
			[Token(Token = "0x4002526")]
			[FieldOffset(Offset = "0x80")]
			public FootstepManager.PlayerFootstepMaterial Ice;

			// Token: 0x04002527 RID: 9511
			[Token(Token = "0x4002527")]
			[FieldOffset(Offset = "0x88")]
			public FootstepManager.PlayerFootstepMaterial Epoxy;

			// Token: 0x04002528 RID: 9512
			[Token(Token = "0x4002528")]
			[FieldOffset(Offset = "0x90")]
			protected Dictionary<UnderfootSurfaceDetector.SurfaceType, FootstepManager.IFootstepMaterial> _matInfos;
		}
	}
}
