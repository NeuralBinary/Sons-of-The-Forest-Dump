using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	public class LightningBoltScript : MonoBehaviour
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000021")]
		public Action<LightningBoltParameters, Vector3, Vector3> LightningStartedCallback
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x784A30", Offset = "0x783030", VA = "0x180784A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x784A40", Offset = "0x783040", VA = "0x180784A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000022")]
		public Action<LightningBoltParameters, Vector3, Vector3> LightningEndedCallback
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x784AA0", Offset = "0x7830A0", VA = "0x180784AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x784AB0", Offset = "0x7830B0", VA = "0x180784AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000023")]
		public Action<Light> LightAddedCallback
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x784BA0", Offset = "0x7831A0", VA = "0x180784BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x784BB0", Offset = "0x7831B0", VA = "0x180784BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000EA RID: 234 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000024")]
		public Action<Light> LightRemovedCallback
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x691530", Offset = "0x68FB30", VA = "0x180691530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0xA2FF40", Offset = "0xA2E540", VA = "0x180A2FF40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x17000025")]
		public bool HasActiveBolts
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0xA3E550", Offset = "0xA3CB50", VA = "0x180A3E550")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000230C File Offset: 0x0000050C
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000026")]
		public static Vector4 TimeVectorSinceStart
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0xA3E5A0", Offset = "0xA3CBA0", VA = "0x180A3E5A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0xA3E600", Offset = "0xA3CC00", VA = "0x180A3E600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00002324 File Offset: 0x00000524
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000027")]
		public static float TimeSinceStart
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0xA3E660", Offset = "0xA3CC60", VA = "0x180A3E660")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0xA3E6B0", Offset = "0xA3CCB0", VA = "0x180A3E6B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000233C File Offset: 0x0000053C
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000028")]
		public static float DeltaTime
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0xA3E710", Offset = "0xA3CD10", VA = "0x180A3E710")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0xA3E760", Offset = "0xA3CD60", VA = "0x180A3E760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xA3E7C0", Offset = "0xA3CDC0", VA = "0x180A3E7C0", Slot = "4")]
		public virtual void CreateLightningBolt(LightningBoltParameters p)
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xA3E950", Offset = "0xA3CF50", VA = "0x180A3E950")]
		public void CreateLightningBolts(ICollection<LightningBoltParameters> parameters)
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xA3EA90", Offset = "0xA3D090", VA = "0x180A3EA90", Slot = "5")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xA3EAA0", Offset = "0xA3D0A0", VA = "0x180A3EAA0", Slot = "6")]
		protected virtual void Start()
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xA3EBD0", Offset = "0xA3D1D0", VA = "0x180A3EBD0", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xA3F0A0", Offset = "0xA3D6A0", VA = "0x180A3F0A0", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xA3F0F0", Offset = "0xA3D6F0", VA = "0x180A3F0F0", Slot = "9")]
		protected virtual LightningBoltParameters OnCreateParameters()
		{
			return null;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xA3F130", Offset = "0xA3D730", VA = "0x180A3F130")]
		protected LightningBoltParameters CreateParameters()
		{
			return null;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xA3F190", Offset = "0xA3D790", VA = "0x180A3F190", Slot = "10")]
		protected virtual void PopulateParameters(LightningBoltParameters parameters)
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000FC RID: 252 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000029")]
		internal Material lightningMaterialMeshInternal
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0xA3F1B0", Offset = "0xA3D7B0", VA = "0x180A3F1B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0xA3F1C0", Offset = "0xA3D7C0", VA = "0x180A3F1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000FE RID: 254 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002A")]
		internal Material lightningMaterialMeshNoGlowInternal
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0xA3F220", Offset = "0xA3D820", VA = "0x180A3F220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0xA3F230", Offset = "0xA3D830", VA = "0x180A3F230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000100")]
		[Address(RVA = "0xA3F290", Offset = "0xA3D890", VA = "0x180A3F290")]
		private Coroutine StartCoroutineWrapper(IEnumerator routine)
		{
			return null;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000101")]
		[Address(RVA = "0xA3F310", Offset = "0xA3D910", VA = "0x180A3F310")]
		private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000102")]
		[Address(RVA = "0xA3F350", Offset = "0xA3D950", VA = "0x180A3F350")]
		private LightningBoltDependencies CreateLightningBoltDependencies(ICollection<LightningBoltParameters> parameters)
		{
			return null;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000103")]
		[Address(RVA = "0xA3FC90", Offset = "0xA3E290", VA = "0x180A3FC90")]
		private void ReturnLightningDependenciesToCache(LightningBoltDependencies d)
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000104")]
		[Address(RVA = "0xA3FED0", Offset = "0xA3E4D0", VA = "0x180A3FED0")]
		internal void OnLightAdded(Light l)
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000105")]
		[Address(RVA = "0xA3FEF0", Offset = "0xA3E4F0", VA = "0x180A3FEF0")]
		internal void OnLightRemoved(Light l)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000106")]
		[Address(RVA = "0xA3FF10", Offset = "0xA3E510", VA = "0x180A3FF10")]
		internal void AddActiveBolt(LightningBolt bolt)
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000107")]
		[Address(RVA = "0xA3FFB0", Offset = "0xA3E5B0", VA = "0x180A3FFB0")]
		private void UpdateShaderIds()
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000108")]
		[Address(RVA = "0xA404B0", Offset = "0xA3EAB0", VA = "0x180A404B0")]
		private void UpdateMaterialsForLastTexture()
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000109")]
		[Address(RVA = "0xA40850", Offset = "0xA3EE50", VA = "0x180A40850")]
		private void UpdateTexture()
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010A")]
		[Address(RVA = "0xA40C40", Offset = "0xA3F240", VA = "0x180A40C40")]
		private void SetMaterialPerspective()
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010B")]
		[Address(RVA = "0xA40EE0", Offset = "0xA3F4E0", VA = "0x180A40EE0")]
		private void SetMaterialOrthographicXY()
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010C")]
		[Address(RVA = "0xA41180", Offset = "0xA3F780", VA = "0x180A41180")]
		private void SetMaterialOrthographicXZ()
		{
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010D")]
		[Address(RVA = "0xA41420", Offset = "0xA3FA20", VA = "0x180A41420")]
		private void SetupMaterialCamera()
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010E")]
		[Address(RVA = "0xA41580", Offset = "0xA3FB80", VA = "0x180A41580")]
		private void EnableKeyword(string keyword, bool enable, Material m)
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010F")]
		[Address(RVA = "0xA41640", Offset = "0xA3FC40", VA = "0x180A41640")]
		private void UpdateShaderParameters()
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000110")]
		[Address(RVA = "0xA42190", Offset = "0xA40790", VA = "0x180A42190")]
		private void CheckCompensateForParentTransform()
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000111")]
		[Address(RVA = "0xA426C0", Offset = "0xA40CC0", VA = "0x180A426C0")]
		private void UpdateCamera()
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000112")]
		[Address(RVA = "0xA42920", Offset = "0xA40F20", VA = "0x180A42920")]
		private LightningBolt GetOrCreateLightningBolt()
		{
			return null;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000113")]
		[Address(RVA = "0xA429F0", Offset = "0xA40FF0", VA = "0x180A429F0")]
		private void UpdateActiveBolts()
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000114")]
		[Address(RVA = "0xA42BB0", Offset = "0xA411B0", VA = "0x180A42BB0")]
		private void OnApplicationQuit()
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000115")]
		[Address(RVA = "0xA42BB0", Offset = "0xA411B0", VA = "0x180A42BB0")]
		private void ShutdownThread()
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000116")]
		[Address(RVA = "0xA42BD0", Offset = "0xA411D0", VA = "0x180A42BD0")]
		private void Cleanup()
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000117")]
		[Address(RVA = "0xA42D60", Offset = "0xA41360", VA = "0x180A42D60")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000118")]
		[Address(RVA = "0xA42F30", Offset = "0xA41530", VA = "0x180A42F30")]
		private void TerminateThread()
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000119")]
		[Address(RVA = "0xA42F70", Offset = "0xA41570", VA = "0x180A42F70")]
		private void OnDisable()
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011A")]
		[Address(RVA = "0xA42F80", Offset = "0xA41580", VA = "0x180A42F80")]
		public LightningBoltScript()
		{
		}

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("The camera the lightning should be shown in. Defaults to the current camera, or the main camera if current camera is null. If you are using a different camera, you may want to put the lightning in it's own layer and cull that layer out of any other cameras.")]
		[Header("Lightning General Properties")]
		public Camera Camera;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Type of camera mode. Auto detects the camera and creates appropriate lightning. Can be overriden to do something more specific regardless of camera.")]
		public CameraMode CameraMode;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x2C")]
		internal CameraMode calculatedCameraMode;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("True if you are using world space coordinates for the lightning bolt, false if you are using coordinates relative to the parent game object.")]
		public bool UseWorldSpace;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x31")]
		[Tooltip("Whether to compensate for the parent transform. Default is false. If true, rotation, scale and position are altered by the parent transform. Use this to fix scaling, rotation and other offset problems with the lightning.")]
		public bool CompensateForParentTransform;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Lightning quality setting. This allows setting limits on generations, lights and shadow casting lights based on the global quality setting.")]
		public LightningBoltQualitySetting QualitySetting;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Whether to use multi-threaded generation of lightning. Lightning will be delayed by about 1 frame if this is turned on, but this can significantly improve performance.")]
		public bool MultiThreaded;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 1000f)]
		[Tooltip("If non-zero, the Camera property is used to get distance of lightning from camera. Lightning generations is reduced for each distance from camera. For example, if LevelOfDetailDistance was 100 and the lightning was 200 away from camera, generations would be reduced by 2, to a minimum of 1.")]
		public float LevelOfDetailDistance;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("True to use game time, false to use real time")]
		public bool UseGameTime;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x48")]
		[Header("Lightning 2D Settings")]
		[Tooltip("Sort layer name")]
		public string SortLayerName;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Order in sort layer")]
		public int SortOrderInLayer;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x54")]
		[Header("Lightning Rendering Properties")]
		[Tooltip("Soft particles factor. 0.01 to 3.0 are typical, 100.0 to disable.")]
		[Range(0.01f, 100f)]
		public float SoftParticlesFactor;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("The render queue for the lightning. -1 for default.")]
		public int RenderQueue;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("Lightning material for mesh renderer - glow")]
		public Material LightningMaterialMesh;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("Lightning material for mesh renderer - bolt")]
		public Material LightningMaterialMeshNoGlow;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x70")]
		[Tooltip("The texture to use for the lightning bolts, or null for the material default texture.")]
		public Texture2D LightningTexture;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x78")]
		[Tooltip("The texture to use for the lightning glow, or null for the material default texture.")]
		public Texture2D LightningGlowTexture;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("Particle system to play at the point of emission (start). 'Emission rate' particles will be emitted all at once.")]
		public ParticleSystem LightningOriginParticleSystem;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x88")]
		[Tooltip("Particle system to play at the point of impact (end). 'Emission rate' particles will be emitted all at once.")]
		public ParticleSystem LightningDestinationParticleSystem;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x90")]
		[Tooltip("Tint color for the lightning")]
		[ColorUsage(true, true)]
		public Color32 LightningTintColor;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x94")]
		[Tooltip("Tint color for the lightning glow")]
		[ColorUsage(true, true)]
		public Color32 GlowTintColor;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x98")]
		[Tooltip("Allow tintint the main trunk differently than forks.")]
		[ColorUsage(true, true)]
		public Color32 MainTrunkTintColor;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x9C")]
		[Tooltip("Source blend mode. Default is SrcAlpha.")]
		public BlendMode SourceBlendMode;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0xA0")]
		[Tooltip("Destination blend mode. Default is One. For additive blend use One. For alpha blend use OneMinusSrcAlpha.")]
		public BlendMode DestinationBlendMode;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0xA4")]
		[Header("Lightning Movement Properties")]
		[Tooltip("Jitter multiplier to randomize lightning size. Jitter depends on trunk width and will make the lightning move rapidly and jaggedly, giving a more lively and sometimes cartoony feel. Jitter may be shared with other bolts depending on materials. If you need different jitters for the same material, create a second script object.")]
		public float JitterMultiplier;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0xA8")]
		[Tooltip("Built in turbulance based on the direction of each segment. Small values usually work better, like 0.2.")]
		public float Turbulence;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0xAC")]
		[Tooltip("Global turbulence velocity for this script")]
		public Vector3 TurbulenceVelocity;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0xB8")]
		[Tooltip("Cause lightning to flicker, x = min, y = max, z = time multiplier, w = add to intensity")]
		public Vector4 IntensityFlicker;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector4 intensityFlickerDefault;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0xC8")]
		[Tooltip("Lightning intensity flicker lookup texture")]
		public Texture2D IntensityFlickerTexture;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x28")]
		public static float TimeScale;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x2C")]
		private static bool needsTimeUpdate;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x100")]
		private Texture2D lastLightningTexture;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x108")]
		private Texture2D lastLightningGlowTexture;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x110")]
		private readonly List<LightningBolt> activeBolts;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x118")]
		private readonly LightningBoltParameters[] oneParameterArray;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x120")]
		private readonly List<LightningBolt> lightningBoltCache;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x128")]
		private readonly List<LightningBoltDependencies> dependenciesCache;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x130")]
		private LightningThreadState threadState;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x30")]
		private static int shaderId_MainTex;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x34")]
		private static int shaderId_TintColor;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x38")]
		private static int shaderId_JitterMultiplier;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x3C")]
		private static int shaderId_Turbulence;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x40")]
		private static int shaderId_TurbulenceVelocity;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x44")]
		private static int shaderId_SrcBlendMode;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x48")]
		private static int shaderId_DstBlendMode;

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x4C")]
		private static int shaderId_InvFade;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x50")]
		private static int shaderId_LightningTime;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x54")]
		private static int shaderId_IntensityFlicker;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x58")]
		private static int shaderId_IntensityFlickerTexture;
	}
}
