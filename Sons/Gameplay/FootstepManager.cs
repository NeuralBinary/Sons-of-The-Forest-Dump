using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000767 RID: 1895
	[Token(Token = "0x2000767")]
	public class FootstepManager : MonoBehaviour
	{
		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06003342 RID: 13122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000691")]
		public static FootstepManager Instance
		{
			[Token(Token = "0x6003342")]
			[Address(RVA = "0x34B44F0", Offset = "0x34B2AF0", VA = "0x1834B44F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003343 RID: 13123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003343")]
		[Address(RVA = "0x34B4530", Offset = "0x34B2B30", VA = "0x1834B4530")]
		public static string GetEventPathIfExists(string path)
		{
			return null;
		}

		// Token: 0x06003344 RID: 13124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003344")]
		[Address(RVA = "0x34B4680", Offset = "0x34B2C80", VA = "0x1834B4680")]
		protected internal void Awake()
		{
		}

		// Token: 0x06003345 RID: 13125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003345")]
		[Address(RVA = "0x34B4800", Offset = "0x34B2E00", VA = "0x1834B4800")]
		private void Start()
		{
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003346")]
		[Address(RVA = "0x34B4890", Offset = "0x34B2E90", VA = "0x1834B4890")]
		private FootstepManager.IFootstepList GetDataForType(FootstepManager.FootstepClassType classType)
		{
			return null;
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003347")]
		[Address(RVA = "0x34B4900", Offset = "0x34B2F00", VA = "0x1834B4900")]
		private void PreloadEvents()
		{
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003348")]
		[Address(RVA = "0x34B4960", Offset = "0x34B2F60", VA = "0x1834B4960")]
		private void OnApplicationQuit()
		{
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003349")]
		[Address(RVA = "0x34B4970", Offset = "0x34B2F70", VA = "0x1834B4970")]
		private void OnDisable()
		{
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
		[Token(Token = "0x600334A")]
		[Address(RVA = "0x34B49E0", Offset = "0x34B2FE0", VA = "0x1834B49E0")]
		private bool ShouldPlay(Vector3 position)
		{
			return default(bool);
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600334B")]
		[Address(RVA = "0x34B4A60", Offset = "0x34B3060", VA = "0x1834B4A60")]
		public void PlayerFootstepForPosition(Vector3 position, UnderfootSurfaceDetector.SurfaceType surfaceType, bool isOnGore, float speed, bool inWater, float waterDepth)
		{
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600334C")]
		[Address(RVA = "0x34B5220", Offset = "0x34B3820", VA = "0x1834B5220")]
		public void PlayerLandForPosition(Vector3 position, UnderfootSurfaceDetector.SurfaceType surfaceType, bool isOnGore, bool inWater, float waterDepth, bool networked)
		{
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600334D")]
		[Address(RVA = "0x34B56E0", Offset = "0x34B3CE0", VA = "0x1834B56E0")]
		public void GenericFootstepForPosition(Vector3 position, FootstepManager.FootstepClassType classType, FootstepManager.SoundType soundType, [Optional] VailActor actorSource)
		{
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x0000F5E8 File Offset: 0x0000D7E8
		[Token(Token = "0x600334E")]
		[Address(RVA = "0x34B5F00", Offset = "0x34B4500", VA = "0x1834B5F00")]
		private UnderfootSurfaceDetector.SurfaceType TraceUnderfootSurface(Vector3 footPos, out float snowDepth)
		{
			return UnderfootSurfaceDetector.SurfaceType.None;
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x0000F600 File Offset: 0x0000D800
		[Token(Token = "0x600334F")]
		[Address(RVA = "0x34B62D0", Offset = "0x34B48D0", VA = "0x1834B62D0")]
		private VailAudioManager.Noise GetNoiseStimuli(FootstepManager.SoundType soundType)
		{
			return VailAudioManager.Noise.Soft;
		}

		// Token: 0x06003350 RID: 13136 RVA: 0x0000F618 File Offset: 0x0000D818
		[Token(Token = "0x6003350")]
		[Address(RVA = "0x34B6300", Offset = "0x34B4900", VA = "0x1834B6300")]
		private UnderfootSurfaceDetector.SurfaceType GetUnderfootSurface(Vector3 position, bool inWater, float snowDepth)
		{
			return UnderfootSurfaceDetector.SurfaceType.None;
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003351")]
		[Address(RVA = "0x34B69B0", Offset = "0x34B4FB0", VA = "0x1834B69B0")]
		public void ToggleDebug()
		{
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003352")]
		[Address(RVA = "0x34B69D0", Offset = "0x34B4FD0", VA = "0x1834B69D0")]
		public FootstepManager()
		{
		}

		// Token: 0x04002C34 RID: 11316
		[Token(Token = "0x4002C34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly LayerMask _traceGroundMask;

		// Token: 0x04002C35 RID: 11317
		[Token(Token = "0x4002C35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private readonly LayerMask _terrainLayerMask;

		// Token: 0x04002C36 RID: 11318
		[Token(Token = "0x4002C36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FootstepManager.PlayerFootstepList _player;

		// Token: 0x04002C37 RID: 11319
		[Token(Token = "0x4002C37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FootstepEventList _mutantRegular;

		// Token: 0x04002C38 RID: 11320
		[Token(Token = "0x4002C38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FootstepEventList _mutantHeavy;

		// Token: 0x04002C39 RID: 11321
		[Token(Token = "0x4002C39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private FootstepEventList _virginia;

		// Token: 0x04002C3A RID: 11322
		[Token(Token = "0x4002C3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FootstepEventList _twins;

		// Token: 0x04002C3B RID: 11323
		[Token(Token = "0x4002C3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private FootstepEventList _demon;

		// Token: 0x04002C3C RID: 11324
		[Token(Token = "0x4002C3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private FootstepEventList _demonBoss;

		// Token: 0x04002C3D RID: 11325
		[Token(Token = "0x4002C3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private FootstepEventList _mutantBoss;

		// Token: 0x04002C3E RID: 11326
		[Token(Token = "0x4002C3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UnderfootSurfaceDetector.SurfaceType[] _terrainTexSurfaceTypes;

		// Token: 0x04002C3F RID: 11327
		[Token(Token = "0x4002C3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private VailAudioManager.Noise _walkStepStimuli;

		// Token: 0x04002C40 RID: 11328
		[Token(Token = "0x4002C40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private VailAudioManager.Noise _runStepStimuli;

		// Token: 0x04002C41 RID: 11329
		[Token(Token = "0x4002C41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private VailAudioManager.Noise _landStimuli;

		// Token: 0x04002C42 RID: 11330
		[Token(Token = "0x4002C42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Tooltip("step must be within this distance of local player to play audio")]
		[SerializeField]
		private float _playStepMaxDist;

		// Token: 0x04002C43 RID: 11331
		[Token(Token = "0x4002C43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float _playLandMaxDist;

		// Token: 0x04002C44 RID: 11332
		[Token(Token = "0x4002C44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float _minSnowDepth;

		// Token: 0x04002C45 RID: 11333
		[Token(Token = "0x4002C45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private bool _debugLog;

		// Token: 0x04002C46 RID: 11334
		[Token(Token = "0x4002C46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		[SerializeField]
		private bool _debugTraces;

		// Token: 0x04002C47 RID: 11335
		[Token(Token = "0x4002C47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		private bool _hasPreloaded;

		// Token: 0x04002C48 RID: 11336
		[Token(Token = "0x4002C48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
		private bool _isApplicationQuitting;

		// Token: 0x04002C49 RID: 11337
		[Token(Token = "0x4002C49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FootstepManager _instance;

		// Token: 0x02000768 RID: 1896
		[Token(Token = "0x2000768")]
		public enum FootstepClassType
		{
			// Token: 0x04002C4B RID: 11339
			[Token(Token = "0x4002C4B")]
			Player,
			// Token: 0x04002C4C RID: 11340
			[Token(Token = "0x4002C4C")]
			MutantRegular,
			// Token: 0x04002C4D RID: 11341
			[Token(Token = "0x4002C4D")]
			MutantHeavy,
			// Token: 0x04002C4E RID: 11342
			[Token(Token = "0x4002C4E")]
			Virginia,
			// Token: 0x04002C4F RID: 11343
			[Token(Token = "0x4002C4F")]
			Twins,
			// Token: 0x04002C50 RID: 11344
			[Token(Token = "0x4002C50")]
			Demon,
			// Token: 0x04002C51 RID: 11345
			[Token(Token = "0x4002C51")]
			DemonBoss,
			// Token: 0x04002C52 RID: 11346
			[Token(Token = "0x4002C52")]
			MutantBoss
		}

		// Token: 0x02000769 RID: 1897
		[Token(Token = "0x2000769")]
		public enum SoundType
		{
			// Token: 0x04002C54 RID: 11348
			[Token(Token = "0x4002C54")]
			Step,
			// Token: 0x04002C55 RID: 11349
			[Token(Token = "0x4002C55")]
			WalkStep,
			// Token: 0x04002C56 RID: 11350
			[Token(Token = "0x4002C56")]
			RunStep,
			// Token: 0x04002C57 RID: 11351
			[Token(Token = "0x4002C57")]
			SneakStep,
			// Token: 0x04002C58 RID: 11352
			[Token(Token = "0x4002C58")]
			Land
		}

		// Token: 0x0200076A RID: 1898
		[Token(Token = "0x200076A")]
		public interface IFootstepMaterial
		{
			// Token: 0x06003353 RID: 13139
			[Token(Token = "0x6003353")]
			void SetToDefaults(string prefix, string prefixLand);

			// Token: 0x06003354 RID: 13140
			[Token(Token = "0x6003354")]
			void PreloadEvents();

			// Token: 0x06003355 RID: 13141
			[Token(Token = "0x6003355")]
			void UnloadEvents();

			// Token: 0x06003356 RID: 13142
			[Token(Token = "0x6003356")]
			string GetEvent(FootstepManager.SoundType soundType);
		}

		// Token: 0x0200076B RID: 1899
		[Token(Token = "0x200076B")]
		[Serializable]
		public class PlayerFootstepMaterial : FootstepManager.IFootstepMaterial
		{
			// Token: 0x06003357 RID: 13143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003357")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			public PlayerFootstepMaterial(string inDefaultDefaultPrefix)
			{
			}

			// Token: 0x06003358 RID: 13144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003358")]
			[Address(RVA = "0x34B6CE0", Offset = "0x34B52E0", VA = "0x1834B6CE0", Slot = "4")]
			public void SetToDefaults(string prefixStep, string prefixLand)
			{
			}

			// Token: 0x06003359 RID: 13145 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003359")]
			[Address(RVA = "0x34B6E20", Offset = "0x34B5420", VA = "0x1834B6E20", Slot = "5")]
			public void PreloadEvents()
			{
			}

			// Token: 0x0600335A RID: 13146 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600335A")]
			[Address(RVA = "0x34B6F30", Offset = "0x34B5530", VA = "0x1834B6F30", Slot = "6")]
			public void UnloadEvents()
			{
			}

			// Token: 0x0600335B RID: 13147 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600335B")]
			[Address(RVA = "0x34B7040", Offset = "0x34B5640", VA = "0x1834B7040", Slot = "7")]
			public string GetEvent(FootstepManager.SoundType type)
			{
				return null;
			}

			// Token: 0x04002C59 RID: 11353
			[Token(Token = "0x4002C59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[EventRef]
			public string StepEvent;

			// Token: 0x04002C5A RID: 11354
			[Token(Token = "0x4002C5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[EventRef]
			public string LandEvent;

			// Token: 0x04002C5B RID: 11355
			[Token(Token = "0x4002C5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[HideInInspector]
			public string DefaultPrefix;
		}

		// Token: 0x0200076C RID: 1900
		[Token(Token = "0x200076C")]
		[Serializable]
		public class MutantFootstepMaterial : FootstepManager.IFootstepMaterial
		{
			// Token: 0x0600335C RID: 13148 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600335C")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			public MutantFootstepMaterial(string inDefaultDefaultPrefix)
			{
			}

			// Token: 0x0600335D RID: 13149 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600335D")]
			[Address(RVA = "0x34B7050", Offset = "0x34B5650", VA = "0x1834B7050", Slot = "4")]
			public void SetToDefaults(string prefixStep, string prefixLand)
			{
			}

			// Token: 0x0600335E RID: 13150 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600335E")]
			[Address(RVA = "0x34B7220", Offset = "0x34B5820", VA = "0x1834B7220", Slot = "7")]
			public string GetEvent(FootstepManager.SoundType type)
			{
				return null;
			}

			// Token: 0x0600335F RID: 13151 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600335F")]
			[Address(RVA = "0x34B72B0", Offset = "0x34B58B0", VA = "0x1834B72B0", Slot = "5")]
			public void PreloadEvents()
			{
			}

			// Token: 0x06003360 RID: 13152 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003360")]
			[Address(RVA = "0x34B73D0", Offset = "0x34B59D0", VA = "0x1834B73D0", Slot = "6")]
			public void UnloadEvents()
			{
			}

			// Token: 0x04002C5C RID: 11356
			[Token(Token = "0x4002C5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[EventRef]
			public string SneakEvent;

			// Token: 0x04002C5D RID: 11357
			[Token(Token = "0x4002C5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[EventRef]
			public string WalkEvent;

			// Token: 0x04002C5E RID: 11358
			[Token(Token = "0x4002C5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[EventRef]
			public string RunEvent;

			// Token: 0x04002C5F RID: 11359
			[Token(Token = "0x4002C5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[EventRef]
			public string LandEvent;

			// Token: 0x04002C60 RID: 11360
			[Token(Token = "0x4002C60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[HideInInspector]
			public string DefaultPrefix;
		}

		// Token: 0x0200076D RID: 1901
		[Token(Token = "0x200076D")]
		public interface IFootstepList
		{
			// Token: 0x06003361 RID: 13153
			[Token(Token = "0x6003361")]
			void PreloadEvents();

			// Token: 0x06003362 RID: 13154
			[Token(Token = "0x6003362")]
			void UnloadEvents();

			// Token: 0x06003363 RID: 13155
			[Token(Token = "0x6003363")]
			string GetEvent(UnderfootSurfaceDetector.SurfaceType surface, FootstepManager.SoundType type);
		}

		// Token: 0x0200076E RID: 1902
		[Token(Token = "0x200076E")]
		[Serializable]
		public class PlayerFootstepList : FootstepManager.IFootstepList
		{
			// Token: 0x06003364 RID: 13156 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003364")]
			[Address(RVA = "0x34B74F0", Offset = "0x34B5AF0", VA = "0x1834B74F0", Slot = "4")]
			public void PreloadEvents()
			{
			}

			// Token: 0x06003365 RID: 13157 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003365")]
			[Address(RVA = "0x34B76F0", Offset = "0x34B5CF0", VA = "0x1834B76F0", Slot = "5")]
			public void UnloadEvents()
			{
			}

			// Token: 0x06003366 RID: 13158 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003366")]
			[Address(RVA = "0x34B78F0", Offset = "0x34B5EF0", VA = "0x1834B78F0", Slot = "6")]
			public string GetEvent(UnderfootSurfaceDetector.SurfaceType surface, FootstepManager.SoundType type)
			{
				return null;
			}

			// Token: 0x06003367 RID: 13159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003367")]
			[Address(RVA = "0x34B79E0", Offset = "0x34B5FE0", VA = "0x1834B79E0")]
			public PlayerFootstepList()
			{
			}

			// Token: 0x04002C61 RID: 11361
			[Token(Token = "0x4002C61")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FootstepManager.PlayerFootstepMaterial Default;

			// Token: 0x04002C62 RID: 11362
			[Token(Token = "0x4002C62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FootstepManager.PlayerFootstepMaterial Sand;

			// Token: 0x04002C63 RID: 11363
			[Token(Token = "0x4002C63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FootstepManager.PlayerFootstepMaterial Mud;

			// Token: 0x04002C64 RID: 11364
			[Token(Token = "0x4002C64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FootstepManager.PlayerFootstepMaterial Leaves;

			// Token: 0x04002C65 RID: 11365
			[Token(Token = "0x4002C65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public FootstepManager.PlayerFootstepMaterial Rock;

			// Token: 0x04002C66 RID: 11366
			[Token(Token = "0x4002C66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public FootstepManager.PlayerFootstepMaterial Snow;

			// Token: 0x04002C67 RID: 11367
			[Token(Token = "0x4002C67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public FootstepManager.PlayerFootstepMaterial Wood;

			// Token: 0x04002C68 RID: 11368
			[Token(Token = "0x4002C68")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public FootstepManager.PlayerFootstepMaterial Metal;

			// Token: 0x04002C69 RID: 11369
			[Token(Token = "0x4002C69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public FootstepManager.PlayerFootstepMaterial MetalGrate;

			// Token: 0x04002C6A RID: 11370
			[Token(Token = "0x4002C6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public FootstepManager.PlayerFootstepMaterial Carpet;

			// Token: 0x04002C6B RID: 11371
			[Token(Token = "0x4002C6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public FootstepManager.PlayerFootstepMaterial Plastic;

			// Token: 0x04002C6C RID: 11372
			[Token(Token = "0x4002C6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public FootstepManager.PlayerFootstepMaterial PlasticBed;

			// Token: 0x04002C6D RID: 11373
			[Token(Token = "0x4002C6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public FootstepManager.PlayerFootstepMaterial BrokenGlass;

			// Token: 0x04002C6E RID: 11374
			[Token(Token = "0x4002C6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public FootstepManager.PlayerFootstepMaterial Water;

			// Token: 0x04002C6F RID: 11375
			[Token(Token = "0x4002C6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public FootstepManager.PlayerFootstepMaterial Ice;

			// Token: 0x04002C70 RID: 11376
			[Token(Token = "0x4002C70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public FootstepManager.PlayerFootstepMaterial Epoxy;

			// Token: 0x04002C71 RID: 11377
			[Token(Token = "0x4002C71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			protected Dictionary<UnderfootSurfaceDetector.SurfaceType, FootstepManager.IFootstepMaterial> _matInfos;
		}
	}
}
