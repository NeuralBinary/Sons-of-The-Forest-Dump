using System;
using Il2CppDummyDll;
using Sons.Legacy.ScionPostProcess.Scripts;
using Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes;
using Sons.Legacy.ScionPostProcess.Scripts.InspectorAttributes.Decorations;
using UnityEngine;

namespace Sons.Legacy.ScionPostProcess
{
	// Token: 0x0200057A RID: 1402
	[Token(Token = "0x200057A")]
	[AddComponentMenu("Image Effects/Scion Post Process")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class ScionPostProcess : MonoBehaviour
	{
		// Token: 0x06002455 RID: 9301 RVA: 0x0000A728 File Offset: 0x00008928
		[Token(Token = "0x6002455")]
		[Address(RVA = "0x5CC180", Offset = "0x5CB180", VA = "0x1805CC180")]
		private bool ShowGrain()
		{
			return default(bool);
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x0000A740 File Offset: 0x00008940
		[Token(Token = "0x6002456")]
		[Address(RVA = "0x5BA880", Offset = "0x5B9880", VA = "0x1805BA880")]
		private bool ShowVignette()
		{
			return default(bool);
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x0000A758 File Offset: 0x00008958
		[Token(Token = "0x6002457")]
		[Address(RVA = "0x8C87D0", Offset = "0x8C77D0", VA = "0x1808C87D0")]
		private bool ShowChromaticAberration()
		{
			return default(bool);
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x0000A770 File Offset: 0x00008970
		[Token(Token = "0x6002458")]
		[Address(RVA = "0x5829E0", Offset = "0x5819E0", VA = "0x1805829E0")]
		private bool ShowTonemapping()
		{
			return default(bool);
		}

		// Token: 0x06002459 RID: 9305 RVA: 0x0000A788 File Offset: 0x00008988
		[Token(Token = "0x6002459")]
		[Address(RVA = "0x86F2D0", Offset = "0x86E2D0", VA = "0x18086F2D0")]
		private bool ShowBloom()
		{
			return default(bool);
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x0000A7A0 File Offset: 0x000089A0
		[Token(Token = "0x600245A")]
		[Address(RVA = "0x2D8E290", Offset = "0x2D8D290", VA = "0x182D8E290")]
		private bool ShowLensDirt()
		{
			return default(bool);
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x0000A7B8 File Offset: 0x000089B8
		[Token(Token = "0x600245B")]
		[Address(RVA = "0x2D8E210", Offset = "0x2D8D210", VA = "0x182D8E210")]
		private bool ShowLensDirtSettings()
		{
			return default(bool);
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x0000A7D0 File Offset: 0x000089D0
		[Token(Token = "0x600245C")]
		[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970")]
		private bool ShowCameraMode()
		{
			return default(bool);
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x0000A7E8 File Offset: 0x000089E8
		[Token(Token = "0x600245D")]
		[Address(RVA = "0x2D8E1C0", Offset = "0x2D8D1C0", VA = "0x182D8E1C0")]
		private bool ShowExposureComp()
		{
			return default(bool);
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x0000A800 File Offset: 0x00008A00
		[Token(Token = "0x600245E")]
		[Address(RVA = "0x2D8E1A0", Offset = "0x2D8D1A0", VA = "0x182D8E1A0")]
		private bool ShowExposureAdaption()
		{
			return default(bool);
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x0000A818 File Offset: 0x00008A18
		[Token(Token = "0x600245F")]
		[Address(RVA = "0x2D8E180", Offset = "0x2D8D180", VA = "0x182D8E180")]
		private bool ShowDownsampleBloomExposure()
		{
			return default(bool);
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x0000A830 File Offset: 0x00008A30
		[Token(Token = "0x6002460")]
		[Address(RVA = "0x6743F0", Offset = "0x6733F0", VA = "0x1806743F0")]
		private bool ShowFocalLength()
		{
			return default(bool);
		}

		// Token: 0x06002461 RID: 9313 RVA: 0x0000A848 File Offset: 0x00008A48
		[Token(Token = "0x6002461")]
		[Address(RVA = "0x2D8E1D0", Offset = "0x2D8D1D0", VA = "0x182D8E1D0")]
		private bool ShowFNumber()
		{
			return default(bool);
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x0000A860 File Offset: 0x00008A60
		[Token(Token = "0x6002462")]
		[Address(RVA = "0x2D8E200", Offset = "0x2D8D200", VA = "0x182D8E200")]
		private bool ShowISO()
		{
			return default(bool);
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x0000A878 File Offset: 0x00008A78
		[Token(Token = "0x6002463")]
		[Address(RVA = "0x2D8E200", Offset = "0x2D8D200", VA = "0x182D8E200")]
		private bool ShowShutterSpeed()
		{
			return default(bool);
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x0000A890 File Offset: 0x00008A90
		[Token(Token = "0x6002464")]
		[Address(RVA = "0x21E9210", Offset = "0x21E8210", VA = "0x1821E9210")]
		private bool ShowDepthOfField()
		{
			return default(bool);
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		[Token(Token = "0x6002465")]
		[Address(RVA = "0x2D8E2A0", Offset = "0x2D8D2A0", VA = "0x182D8E2A0")]
		private bool ShowPointAverage()
		{
			return default(bool);
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x0000A8C0 File Offset: 0x00008AC0
		[Token(Token = "0x6002466")]
		[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0")]
		private bool ShowFocalDistance()
		{
			return default(bool);
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x0000A8D8 File Offset: 0x00008AD8
		[Token(Token = "0x6002467")]
		[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0")]
		private bool ShowFocalRange()
		{
			return default(bool);
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		[Token(Token = "0x6002468")]
		[Address(RVA = "0x2D8E170", Offset = "0x2D8D170", VA = "0x182D8E170")]
		private bool ShowCCTex1()
		{
			return default(bool);
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x0000A908 File Offset: 0x00008B08
		[Token(Token = "0x6002469")]
		[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0")]
		private bool ShowCCTex2()
		{
			return default(bool);
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x0600246A RID: 9322 RVA: 0x0000A920 File Offset: 0x00008B20
		// (set) Token: 0x0600246B RID: 9323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D2")]
		public CameraMode cameraMode
		{
			[Token(Token = "0x600246A")]
			[Address(RVA = "0x986680", Offset = "0x985680", VA = "0x180986680")]
			get
			{
				return CameraMode.Off;
			}
			[Token(Token = "0x600246B")]
			[Address(RVA = "0x2D8E610", Offset = "0x2D8D610", VA = "0x182D8E610")]
			set
			{
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x0600246C RID: 9324 RVA: 0x0000A938 File Offset: 0x00008B38
		// (set) Token: 0x0600246D RID: 9325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D3")]
		public bool tonemapping
		{
			[Token(Token = "0x600246C")]
			[Address(RVA = "0x5829E0", Offset = "0x5819E0", VA = "0x1805829E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600246D")]
			[Address(RVA = "0x2D8ED10", Offset = "0x2D8DD10", VA = "0x182D8ED10")]
			set
			{
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x0600246E RID: 9326 RVA: 0x0000A950 File Offset: 0x00008B50
		// (set) Token: 0x0600246F RID: 9327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D4")]
		public bool bloom
		{
			[Token(Token = "0x600246E")]
			[Address(RVA = "0x86F2D0", Offset = "0x86E2D0", VA = "0x18086F2D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600246F")]
			[Address(RVA = "0x2D8E5E0", Offset = "0x2D8D5E0", VA = "0x182D8E5E0")]
			set
			{
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06002470 RID: 9328 RVA: 0x0000A968 File Offset: 0x00008B68
		// (set) Token: 0x06002471 RID: 9329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D5")]
		public bool lensDirt
		{
			[Token(Token = "0x6002470")]
			[Address(RVA = "0x25B46D0", Offset = "0x25B36D0", VA = "0x1825B46D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002471")]
			[Address(RVA = "0x2D8EBF0", Offset = "0x2D8DBF0", VA = "0x182D8EBF0")]
			set
			{
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06002472 RID: 9330 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002473 RID: 9331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D6")]
		public Texture2D lensDirtTexture
		{
			[Token(Token = "0x6002472")]
			[Address(RVA = "0x656130", Offset = "0x655130", VA = "0x180656130")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002473")]
			[Address(RVA = "0x2D8EBA0", Offset = "0x2D8DBA0", VA = "0x182D8EBA0")]
			set
			{
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06002474 RID: 9332 RVA: 0x0000A980 File Offset: 0x00008B80
		// (set) Token: 0x06002475 RID: 9333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D7")]
		public bool depthOfField
		{
			[Token(Token = "0x6002474")]
			[Address(RVA = "0x21E9210", Offset = "0x21E8210", VA = "0x1821E9210")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002475")]
			[Address(RVA = "0x2D8E9A0", Offset = "0x2D8D9A0", VA = "0x182D8E9A0")]
			set
			{
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06002476 RID: 9334 RVA: 0x0000A998 File Offset: 0x00008B98
		// (set) Token: 0x06002477 RID: 9335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D8")]
		public float bloomIntensity
		{
			[Token(Token = "0x6002476")]
			[Address(RVA = "0x1C71DD0", Offset = "0x1C70DD0", VA = "0x181C71DD0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6002477")]
			[Address(RVA = "0x2D8E5B0", Offset = "0x2D8D5B0", VA = "0x182D8E5B0")]
			set
			{
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06002478 RID: 9336 RVA: 0x0000A9B0 File Offset: 0x00008BB0
		// (set) Token: 0x06002479 RID: 9337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D9")]
		public float bloomBrightness
		{
			[Token(Token = "0x6002478")]
			[Address(RVA = "0x1BF5800", Offset = "0x1BF4800", VA = "0x181BF5800")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6002479")]
			[Address(RVA = "0x2D8E4E0", Offset = "0x2D8D4E0", VA = "0x182D8E4E0")]
			set
			{
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x0600247A RID: 9338 RVA: 0x0000A9C8 File Offset: 0x00008BC8
		// (set) Token: 0x0600247B RID: 9339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004DA")]
		public int bloomDownsamples
		{
			[Token(Token = "0x600247A")]
			[Address(RVA = "0x8E3D80", Offset = "0x8E2D80", VA = "0x1808E3D80")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600247B")]
			[Address(RVA = "0x2D8E510", Offset = "0x2D8D510", VA = "0x182D8E510")]
			set
			{
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x0600247C RID: 9340 RVA: 0x0000A9E0 File Offset: 0x00008BE0
		// (set) Token: 0x0600247D RID: 9341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004DB")]
		public float lensDirtIntensity
		{
			[Token(Token = "0x600247C")]
			[Address(RVA = "0x20452F0", Offset = "0x20442F0", VA = "0x1820452F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600247D")]
			[Address(RVA = "0x2D8EB70", Offset = "0x2D8DB70", VA = "0x182D8EB70")]
			set
			{
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x0600247E RID: 9342 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		// (set) Token: 0x0600247F RID: 9343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004DC")]
		public float lensDirtBrightness
		{
			[Token(Token = "0x600247E")]
			[Address(RVA = "0x58ECE0", Offset = "0x58DCE0", VA = "0x18058ECE0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600247F")]
			[Address(RVA = "0x2D8EB40", Offset = "0x2D8DB40", VA = "0x182D8EB40")]
			set
			{
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06002480 RID: 9344 RVA: 0x0000AA10 File Offset: 0x00008C10
		// (set) Token: 0x06002481 RID: 9345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004DD")]
		public DepthFocusMode depthFocusMode
		{
			[Token(Token = "0x6002480")]
			[Address(RVA = "0x986240", Offset = "0x985240", VA = "0x180986240")]
			get
			{
				return (DepthFocusMode)0;
			}
			[Token(Token = "0x6002481")]
			[Address(RVA = "0x2D8E920", Offset = "0x2D8D920", VA = "0x182D8E920")]
			set
			{
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06002482 RID: 9346 RVA: 0x0000AA28 File Offset: 0x00008C28
		// (set) Token: 0x06002483 RID: 9347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004DE")]
		public float maxCoCRadius
		{
			[Token(Token = "0x6002482")]
			[Address(RVA = "0x22E98B0", Offset = "0x22E88B0", VA = "0x1822E98B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6002483")]
			[Address(RVA = "0x2D8EC20", Offset = "0x2D8DC20", VA = "0x182D8EC20")]
			set
			{
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06002484 RID: 9348 RVA: 0x0000AA40 File Offset: 0x00008C40
		// (set) Token: 0x06002485 RID: 9349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004DF")]
		public DepthOfFieldQuality depthOfFieldQuality
		{
			[Token(Token = "0x6002484")]
			[Address(RVA = "0x6743B0", Offset = "0x6733B0", VA = "0x1806743B0")]
			get
			{
				return DepthOfFieldQuality.Normal;
			}
			[Token(Token = "0x6002485")]
			[Address(RVA = "0x2D8E950", Offset = "0x2D8D950", VA = "0x182D8E950")]
			set
			{
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06002486 RID: 9350 RVA: 0x0000AA58 File Offset: 0x00008C58
		// (set) Token: 0x06002487 RID: 9351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E0")]
		public Vector2 pointAveragePosition
		{
			[Token(Token = "0x6002486")]
			[Address(RVA = "0x2D8E460", Offset = "0x2D8D460", VA = "0x182D8E460")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6002487")]
			[Address(RVA = "0x2D8EC80", Offset = "0x2D8DC80", VA = "0x182D8EC80")]
			set
			{
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06002488 RID: 9352 RVA: 0x0000AA70 File Offset: 0x00008C70
		// (set) Token: 0x06002489 RID: 9353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E1")]
		public float pointAverageRange
		{
			[Token(Token = "0x6002488")]
			[Address(RVA = "0x22E9870", Offset = "0x22E8870", VA = "0x1822E9870")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6002489")]
			[Address(RVA = "0x2D8ECB0", Offset = "0x2D8DCB0", VA = "0x182D8ECB0")]
			set
			{
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x0600248A RID: 9354 RVA: 0x0000AA88 File Offset: 0x00008C88
		// (set) Token: 0x0600248B RID: 9355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E2")]
		public bool visualizePointFocus
		{
			[Token(Token = "0x600248A")]
			[Address(RVA = "0x255D2C0", Offset = "0x255C2C0", VA = "0x18255D2C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600248B")]
			[Address(RVA = "0x2D8EE20", Offset = "0x2D8DE20", VA = "0x182D8EE20")]
			set
			{
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x0600248C RID: 9356 RVA: 0x0000AAA0 File Offset: 0x00008CA0
		// (set) Token: 0x0600248D RID: 9357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E3")]
		public float depthAdaptionSpeed
		{
			[Token(Token = "0x600248C")]
			[Address(RVA = "0x22E9880", Offset = "0x22E8880", VA = "0x1822E9880")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600248D")]
			[Address(RVA = "0x2D8E8F0", Offset = "0x2D8D8F0", VA = "0x182D8E8F0")]
			set
			{
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x0600248E RID: 9358 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		// (set) Token: 0x0600248F RID: 9359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E4")]
		public float focalDistance
		{
			[Token(Token = "0x600248E")]
			[Address(RVA = "0x2397C70", Offset = "0x2396C70", VA = "0x182397C70")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600248F")]
			[Address(RVA = "0x2D8EA30", Offset = "0x2D8DA30", VA = "0x182D8EA30")]
			set
			{
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06002490 RID: 9360 RVA: 0x0000AAD0 File Offset: 0x00008CD0
		// (set) Token: 0x06002491 RID: 9361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E5")]
		public float focalRange
		{
			[Token(Token = "0x6002490")]
			[Address(RVA = "0x600290", Offset = "0x5FF290", VA = "0x180600290")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6002491")]
			[Address(RVA = "0x2D8EA90", Offset = "0x2D8DA90", VA = "0x182D8EA90")]
			set
			{
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06002492 RID: 9362 RVA: 0x0000AAE8 File Offset: 0x00008CE8
		// (set) Token: 0x06002493 RID: 9363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E6")]
		public ColorGradingMode colorGradingMode
		{
			[Token(Token = "0x6002492")]
			[Address(RVA = "0x986210", Offset = "0x985210", VA = "0x180986210")]
			get
			{
				return ColorGradingMode.Off;
			}
			[Token(Token = "0x6002493")]
			[Address(RVA = "0x2D8E740", Offset = "0x2D8D740", VA = "0x182D8E740")]
			set
			{
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06002494 RID: 9364 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002495 RID: 9365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E7")]
		public Texture2D colorGradingTex1
		{
			[Token(Token = "0x6002494")]
			[Address(RVA = "0x6B72C0", Offset = "0x6B62C0", VA = "0x1806B72C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002495")]
			[Address(RVA = "0x2D8E7D0", Offset = "0x2D8D7D0", VA = "0x182D8E7D0")]
			set
			{
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06002496 RID: 9366 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002497 RID: 9367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E8")]
		public Texture2D colorGradingTex2
		{
			[Token(Token = "0x6002496")]
			[Address(RVA = "0x604130", Offset = "0x603130", VA = "0x180604130")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002497")]
			[Address(RVA = "0x2D8E8A0", Offset = "0x2D8D8A0", VA = "0x182D8E8A0")]
			set
			{
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06002498 RID: 9368 RVA: 0x0000AB00 File Offset: 0x00008D00
		// (set) Token: 0x06002499 RID: 9369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E9")]
		public float colorGradingBlendFactor
		{
			[Token(Token = "0x6002498")]
			[Address(RVA = "0x1145BE0", Offset = "0x1144BE0", VA = "0x181145BE0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6002499")]
			[Address(RVA = "0x2D8E6E0", Offset = "0x2D8D6E0", VA = "0x182D8E6E0")]
			set
			{
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x0600249A RID: 9370 RVA: 0x0000AB18 File Offset: 0x00008D18
		// (set) Token: 0x0600249B RID: 9371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EA")]
		public ColorGradingCompatibility colorGradingCompatibility
		{
			[Token(Token = "0x600249A")]
			[Address(RVA = "0x5E4010", Offset = "0x5E3010", VA = "0x1805E4010")]
			get
			{
				return (ColorGradingCompatibility)0;
			}
			[Token(Token = "0x600249B")]
			[Address(RVA = "0x2D8E710", Offset = "0x2D8D710", VA = "0x182D8E710")]
			set
			{
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x0600249C RID: 9372 RVA: 0x0000AB30 File Offset: 0x00008D30
		// (set) Token: 0x0600249D RID: 9373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EB")]
		public bool userControlledFocalLength
		{
			[Token(Token = "0x600249C")]
			[Address(RVA = "0x6743F0", Offset = "0x6733F0", VA = "0x1806743F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600249D")]
			[Address(RVA = "0x674510", Offset = "0x673510", VA = "0x180674510")]
			set
			{
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x0600249E RID: 9374 RVA: 0x0000AB48 File Offset: 0x00008D48
		// (set) Token: 0x0600249F RID: 9375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EC")]
		public float focalLength
		{
			[Token(Token = "0x600249E")]
			[Address(RVA = "0x674460", Offset = "0x673460", VA = "0x180674460")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600249F")]
			[Address(RVA = "0x2D8EA60", Offset = "0x2D8DA60", VA = "0x182D8EA60")]
			set
			{
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060024A0 RID: 9376 RVA: 0x0000AB60 File Offset: 0x00008D60
		// (set) Token: 0x060024A1 RID: 9377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004ED")]
		public float fNumber
		{
			[Token(Token = "0x60024A0")]
			[Address(RVA = "0x200F4C0", Offset = "0x200E4C0", VA = "0x18200F4C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60024A1")]
			[Address(RVA = "0x2D8EA00", Offset = "0x2D8DA00", VA = "0x182D8EA00")]
			set
			{
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060024A2 RID: 9378 RVA: 0x0000AB78 File Offset: 0x00008D78
		// (set) Token: 0x060024A3 RID: 9379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EE")]
		public float ISO
		{
			[Token(Token = "0x60024A2")]
			[Address(RVA = "0x1526940", Offset = "0x1525940", VA = "0x181526940")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60024A3")]
			[Address(RVA = "0x2D8E480", Offset = "0x2D8D480", VA = "0x182D8E480")]
			set
			{
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060024A4 RID: 9380 RVA: 0x0000AB90 File Offset: 0x00008D90
		// (set) Token: 0x060024A5 RID: 9381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EF")]
		public float shutterSpeed
		{
			[Token(Token = "0x60024A4")]
			[Address(RVA = "0x674380", Offset = "0x673380", VA = "0x180674380")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60024A5")]
			[Address(RVA = "0x2D8ECE0", Offset = "0x2D8DCE0", VA = "0x182D8ECE0")]
			set
			{
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060024A6 RID: 9382 RVA: 0x0000ABA8 File Offset: 0x00008DA8
		// (set) Token: 0x060024A7 RID: 9383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F0")]
		public float adaptionSpeed
		{
			[Token(Token = "0x60024A6")]
			[Address(RVA = "0x20452D0", Offset = "0x20442D0", VA = "0x1820452D0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60024A7")]
			[Address(RVA = "0x2D8E4B0", Offset = "0x2D8D4B0", VA = "0x182D8E4B0")]
			set
			{
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060024A8 RID: 9384 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		// (set) Token: 0x060024A9 RID: 9385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F1")]
		public Vector2 minMaxExposure
		{
			[Token(Token = "0x60024A8")]
			[Address(RVA = "0x1047370", Offset = "0x1046370", VA = "0x181047370")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60024A9")]
			[Address(RVA = "0x2D8EC50", Offset = "0x2D8DC50", VA = "0x182D8EC50")]
			set
			{
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x060024AA RID: 9386 RVA: 0x0000ABD8 File Offset: 0x00008DD8
		// (set) Token: 0x060024AB RID: 9387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F2")]
		public float exposureCompensation
		{
			[Token(Token = "0x60024AA")]
			[Address(RVA = "0x6743D0", Offset = "0x6733D0", VA = "0x1806743D0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60024AB")]
			[Address(RVA = "0x2D8E9D0", Offset = "0x2D8D9D0", VA = "0x182D8E9D0")]
			set
			{
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060024AC RID: 9388 RVA: 0x0000ABF0 File Offset: 0x00008DF0
		// (set) Token: 0x060024AD RID: 9389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F3")]
		public bool grain
		{
			[Token(Token = "0x60024AC")]
			[Address(RVA = "0x5CC180", Offset = "0x5CB180", VA = "0x1805CC180")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60024AD")]
			[Address(RVA = "0x2D8EB00", Offset = "0x2D8DB00", VA = "0x182D8EB00")]
			set
			{
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x060024AE RID: 9390 RVA: 0x0000AC08 File Offset: 0x00008E08
		// (set) Token: 0x060024AF RID: 9391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F4")]
		public float grainIntensity
		{
			[Token(Token = "0x60024AE")]
			[Address(RVA = "0x567910", Offset = "0x566910", VA = "0x180567910")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60024AF")]
			[Address(RVA = "0x2D8EAC0", Offset = "0x2D8DAC0", VA = "0x182D8EAC0")]
			set
			{
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x060024B0 RID: 9392 RVA: 0x0000AC20 File Offset: 0x00008E20
		// (set) Token: 0x060024B1 RID: 9393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F5")]
		public bool vignette
		{
			[Token(Token = "0x60024B0")]
			[Address(RVA = "0x5BA880", Offset = "0x5B9880", VA = "0x1805BA880")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60024B1")]
			[Address(RVA = "0x2D8EDE0", Offset = "0x2D8DDE0", VA = "0x182D8EDE0")]
			set
			{
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060024B2 RID: 9394 RVA: 0x0000AC38 File Offset: 0x00008E38
		// (set) Token: 0x060024B3 RID: 9395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F6")]
		public float vignetteIntensity
		{
			[Token(Token = "0x60024B2")]
			[Address(RVA = "0x5A46C0", Offset = "0x5A36C0", VA = "0x1805A46C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60024B3")]
			[Address(RVA = "0x2D8ED70", Offset = "0x2D8DD70", VA = "0x182D8ED70")]
			set
			{
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060024B4 RID: 9396 RVA: 0x0000AC50 File Offset: 0x00008E50
		// (set) Token: 0x060024B5 RID: 9397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F7")]
		public float vignetteScale
		{
			[Token(Token = "0x60024B4")]
			[Address(RVA = "0x8A27B0", Offset = "0x8A17B0", VA = "0x1808A27B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60024B5")]
			[Address(RVA = "0x2D8EDB0", Offset = "0x2D8DDB0", VA = "0x182D8EDB0")]
			set
			{
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060024B6 RID: 9398 RVA: 0x0000AC68 File Offset: 0x00008E68
		// (set) Token: 0x060024B7 RID: 9399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F8")]
		public Color vignetteColor
		{
			[Token(Token = "0x60024B6")]
			[Address(RVA = "0x28CA2D0", Offset = "0x28C92D0", VA = "0x1828CA2D0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60024B7")]
			[Address(RVA = "0x2D8ED40", Offset = "0x2D8DD40", VA = "0x182D8ED40")]
			set
			{
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x060024B8 RID: 9400 RVA: 0x0000AC80 File Offset: 0x00008E80
		// (set) Token: 0x060024B9 RID: 9401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F9")]
		public bool chromaticAberration
		{
			[Token(Token = "0x60024B8")]
			[Address(RVA = "0x8C87D0", Offset = "0x8C77D0", VA = "0x1808C87D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60024B9")]
			[Address(RVA = "0x2D8E6B0", Offset = "0x2D8D6B0", VA = "0x182D8E6B0")]
			set
			{
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060024BA RID: 9402 RVA: 0x0000AC98 File Offset: 0x00008E98
		// (set) Token: 0x060024BB RID: 9403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FA")]
		public float chromaticAberrationDistortion
		{
			[Token(Token = "0x60024BA")]
			[Address(RVA = "0x580890", Offset = "0x57F890", VA = "0x180580890")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60024BB")]
			[Address(RVA = "0x2D8E650", Offset = "0x2D8D650", VA = "0x182D8E650")]
			set
			{
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060024BC RID: 9404 RVA: 0x0000ACB0 File Offset: 0x00008EB0
		// (set) Token: 0x060024BD RID: 9405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FB")]
		public float chromaticAberrationIntensity
		{
			[Token(Token = "0x60024BC")]
			[Address(RVA = "0x5808F0", Offset = "0x57F8F0", VA = "0x1805808F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60024BD")]
			[Address(RVA = "0x2D8E680", Offset = "0x2D8D680", VA = "0x182D8E680")]
			set
			{
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060024BE RID: 9406 RVA: 0x0000ACC8 File Offset: 0x00008EC8
		// (set) Token: 0x060024BF RID: 9407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FC")]
		public TonemappingMode tonemappingMode
		{
			[Token(Token = "0x60024BE")]
			[Address(RVA = "0x6587B0", Offset = "0x6577B0", VA = "0x1806587B0")]
			get
			{
				return (TonemappingMode)0;
			}
			[Token(Token = "0x60024BF")]
			[Address(RVA = "0x7D80A0", Offset = "0x7D70A0", VA = "0x1807D80A0")]
			set
			{
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060024C0 RID: 9408 RVA: 0x0000ACE0 File Offset: 0x00008EE0
		// (set) Token: 0x060024C1 RID: 9409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FD")]
		public float whitePoint
		{
			[Token(Token = "0x60024C0")]
			[Address(RVA = "0x20480A0", Offset = "0x20470A0", VA = "0x1820480A0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60024C1")]
			[Address(RVA = "0x2D8EE50", Offset = "0x2D8DE50", VA = "0x182D8EE50")]
			set
			{
			}
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C2")]
		[Address(RVA = "0x2D8C720", Offset = "0x2D8B720", VA = "0x182D8C720")]
		private void OnEnable()
		{
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C3")]
		[Address(RVA = "0x2D8C670", Offset = "0x2D8B670", VA = "0x182D8C670")]
		private void OnDisable()
		{
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C4")]
		[Address(RVA = "0x2D8CD00", Offset = "0x2D8BD00", VA = "0x182D8CD00")]
		private void OnPreRender()
		{
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C5")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void ProcessColorGradingTexture1()
		{
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C6")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void ProcessColorGradingTexture2()
		{
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x0000ACF8 File Offset: 0x00008EF8
		[Token(Token = "0x60024C7")]
		[Address(RVA = "0x2D8D760", Offset = "0x2D8C760", VA = "0x182D8D760")]
		private bool PlatformCompatibility()
		{
			return default(bool);
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C8")]
		[Address(RVA = "0x2D8DE10", Offset = "0x2D8CE10", VA = "0x182D8DE10")]
		private void SetupPostProcessParameters(PostProcessParameters postProcessParams, RenderTexture source)
		{
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C9")]
		[Address(RVA = "0x2D8DA90", Offset = "0x2D8CA90", VA = "0x182D8DA90")]
		private void SetGlobalParameters(PostProcessParameters postProcessParams)
		{
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CA")]
		[Address(RVA = "0x2D8DC90", Offset = "0x2D8CC90", VA = "0x182D8DC90")]
		private void SetShaderKeyWords(PostProcessParameters postProcessParams)
		{
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CB")]
		[Address(RVA = "0x2D8CD40", Offset = "0x2D8BD40", VA = "0x182D8CD40")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture dest)
		{
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CC")]
		[Address(RVA = "0x2D8CFA0", Offset = "0x2D8BFA0", VA = "0x182D8CFA0")]
		private void PerformPostProcessing(RenderTexture source, RenderTexture dest, PostProcessParameters postProcessParams)
		{
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024CD")]
		[Address(RVA = "0x2D8E2C0", Offset = "0x2D8D2C0", VA = "0x182D8E2C0")]
		public ScionPostProcess()
		{
		}

		// Token: 0x040020BB RID: 8379
		[Token(Token = "0x40020BB")]
		[FieldOffset(Offset = "0x20")]
		[Header(0, "Grain")]
		[Toggle("Active", useProperty = "grain", tooltip = "Determines if grain is used")]
		public bool m_grain;

		// Token: 0x040020BC RID: 8380
		[Token(Token = "0x40020BC")]
		[FieldOffset(Offset = "0x24")]
		[Slider("Intensity", useProperty = "grainIntensity", visibleCheck = "ShowGrain", minValue = 0f, maxValue = 1f, tooltip = "How strong the grain effect is")]
		public float m_grainIntensity;

		// Token: 0x040020BD RID: 8381
		[Token(Token = "0x40020BD")]
		[FieldOffset(Offset = "0x28")]
		[Header(0, "Vignette")]
		[Toggle("Active", useProperty = "vignette", tooltip = "Determines if vignette is used")]
		public bool m_vignette;

		// Token: 0x040020BE RID: 8382
		[Token(Token = "0x40020BE")]
		[FieldOffset(Offset = "0x2C")]
		[Slider("Intensity", useProperty = "vignetteIntensity", visibleCheck = "ShowVignette", minValue = 0f, maxValue = 1f, tooltip = "How strong the vignette effect is")]
		public float m_vignetteIntensity;

		// Token: 0x040020BF RID: 8383
		[Token(Token = "0x40020BF")]
		[FieldOffset(Offset = "0x30")]
		[Slider("Scale", useProperty = "vignetteScale", visibleCheck = "ShowVignette", minValue = 0f, maxValue = 1f, tooltip = "How much of the screen is affected")]
		public float m_vignetteScale;

		// Token: 0x040020C0 RID: 8384
		[Token(Token = "0x40020C0")]
		[FieldOffset(Offset = "0x34")]
		[Field("Color", useProperty = "vignetteColor", visibleCheck = "ShowVignette", tooltip = "What color the vignette effect has")]
		public Color m_vignetteColor;

		// Token: 0x040020C1 RID: 8385
		[Token(Token = "0x40020C1")]
		[FieldOffset(Offset = "0x44")]
		[Header(0, "Chromatic Aberration")]
		[Toggle("Active", useProperty = "chromaticAberration", tooltip = "Determines if chromatic aberration is used")]
		public bool m_chromaticAberration;

		// Token: 0x040020C2 RID: 8386
		[Token(Token = "0x40020C2")]
		[FieldOffset(Offset = "0x48")]
		[Slider("Distortion Scale", useProperty = "chromaticAberrationDistortion", visibleCheck = "ShowChromaticAberration", minValue = 0f, maxValue = 1f, tooltip = "How much of the screen is affected")]
		public float m_chromaticAberrationDistortion;

		// Token: 0x040020C3 RID: 8387
		[Token(Token = "0x40020C3")]
		[FieldOffset(Offset = "0x4C")]
		[Slider("Intensity", useProperty = "chromaticAberrationIntensity", visibleCheck = "ShowChromaticAberration", minValue = -30f, maxValue = 30f, tooltip = "How strong the distortion effect is")]
		public float m_chromaticAberrationIntensity;

		// Token: 0x040020C4 RID: 8388
		[Token(Token = "0x40020C4")]
		[FieldOffset(Offset = "0x50")]
		[Toggle("Active", useProperty = "tonemapping", tooltip = "Determines if tonemapping is used")]
		[Header(0, "Tonemapping")]
		public bool m_tonemapping;

		// Token: 0x040020C5 RID: 8389
		[Token(Token = "0x40020C5")]
		[FieldOffset(Offset = "0x54")]
		[Field("Mode", useProperty = "tonemappingMode", visibleCheck = "ShowTonemapping", tooltip = "What type of tonemapping algorithm is used")]
		public TonemappingMode m_tonemappingMode;

		// Token: 0x040020C6 RID: 8390
		[Token(Token = "0x40020C6")]
		[FieldOffset(Offset = "0x58")]
		[Slider("White Point", useProperty = "whitePoint", visibleCheck = "ShowTonemapping", minValue = 0.5f, maxValue = 20f, tooltip = "At what intensity pixels will become white")]
		public float m_whitePoint;

		// Token: 0x040020C7 RID: 8391
		[Token(Token = "0x40020C7")]
		[FieldOffset(Offset = "0x5C")]
		[Header(0, "Bloom")]
		[Toggle("Active", useProperty = "bloom", tooltip = "Determines if bloom is used")]
		public bool m_bloom;

		// Token: 0x040020C8 RID: 8392
		[Token(Token = "0x40020C8")]
		[FieldOffset(Offset = "0x60")]
		[Slider("Intensity", useProperty = "bloomIntensity", visibleCheck = "ShowBloom", minValue = 0f, maxValue = 1f, tooltip = "How strong the bloom effect is")]
		public float m_bloomIntensity;

		// Token: 0x040020C9 RID: 8393
		[Token(Token = "0x40020C9")]
		[FieldOffset(Offset = "0x64")]
		[Slider("Brightness", useProperty = "bloomBrightness", visibleCheck = "ShowBloom", minValue = 0.5f, maxValue = 2f, tooltip = "How bright the bloom effect is")]
		public float m_bloomBrightness;

		// Token: 0x040020CA RID: 8394
		[Token(Token = "0x40020CA")]
		[FieldOffset(Offset = "0x68")]
		[Slider("Downsamples", useProperty = "bloomDownsamples", visibleCheck = "ShowBloom", minValue = 2f, maxValue = 9f, tooltip = "Number of downsamples")]
		public int m_bloomDownsamples;

		// Token: 0x040020CB RID: 8395
		[Token(Token = "0x40020CB")]
		[FieldOffset(Offset = "0x6C")]
		[Header(0, "Lens Dirt", visibleCheck = "ShowBloom")]
		[Toggle("Active", useProperty = "lensDirt", visibleCheck = "ShowBloom", tooltip = "Determines if lens dirt is used")]
		public bool m_lensDirt;

		// Token: 0x040020CC RID: 8396
		[Token(Token = "0x40020CC")]
		[FieldOffset(Offset = "0x70")]
		[Field("Dirt Texture", useProperty = "lensDirtTexture", visibleCheck = "ShowLensDirt", tooltip = "What type of tonemapping algorithm is used")]
		public Texture2D m_lensDirtTexture;

		// Token: 0x040020CD RID: 8397
		[Token(Token = "0x40020CD")]
		[FieldOffset(Offset = "0x78")]
		[Slider("Intensity", useProperty = "lensDirtIntensity", visibleCheck = "ShowLensDirtSettings", minValue = 0f, maxValue = 1f, tooltip = "How strong the lens dirt effect is")]
		public float m_lensDirtIntensity;

		// Token: 0x040020CE RID: 8398
		[Token(Token = "0x40020CE")]
		[FieldOffset(Offset = "0x7C")]
		[Slider("Brightness", useProperty = "lensDirtBrightness", visibleCheck = "ShowLensDirtSettings", minValue = 0.5f, maxValue = 2f, tooltip = "How bright the lens dirt effect is")]
		public float m_lensDirtBrightness;

		// Token: 0x040020CF RID: 8399
		[Token(Token = "0x40020CF")]
		[FieldOffset(Offset = "0x80")]
		[Header(0, "Camera Mode")]
		[Field("Camera Mode", useProperty = "cameraMode", visibleCheck = "ShowCameraMode", tooltip = "What camera mode is used")]
		public CameraMode m_cameraMode;

		// Token: 0x040020D0 RID: 8400
		[Token(Token = "0x40020D0")]
		[FieldOffset(Offset = "0x84")]
		[Slider("F Number", useProperty = "fNumber", visibleCheck = "ShowFNumber", minValue = 1f, maxValue = 22f, tooltip = "The F number of the camera")]
		public float m_fNumber;

		// Token: 0x040020D1 RID: 8401
		[Token(Token = "0x40020D1")]
		[FieldOffset(Offset = "0x88")]
		[Slider("ISO", useProperty = "ISO", visibleCheck = "ShowISO", minValue = 100f, maxValue = 6400f, tooltip = "The ISO setting of the camera")]
		public float m_ISO;

		// Token: 0x040020D2 RID: 8402
		[Token(Token = "0x40020D2")]
		[FieldOffset(Offset = "0x8C")]
		[Slider("Shutter Speed", useProperty = "shutterSpeed", visibleCheck = "ShowShutterSpeed", minValue = 0.00025f, maxValue = 0.033333335f, tooltip = "The shutted speed of the camera")]
		public float m_shutterSpeed;

		// Token: 0x040020D3 RID: 8403
		[Token(Token = "0x40020D3")]
		[FieldOffset(Offset = "0x90")]
		[Toggle("Custom Focal Length", useProperty = "userControlledFocalLength", tooltip = "If false the focal length will instead be derived from the camera's field of view")]
		public bool m_userControlledFocalLength;

		// Token: 0x040020D4 RID: 8404
		[Token(Token = "0x40020D4")]
		[FieldOffset(Offset = "0x94")]
		[Slider("Focal Length", useProperty = "focalLength", visibleCheck = "ShowFocalLength", minValue = 10f, maxValue = 250f, tooltip = "The focal length of the camera in millimeters")]
		public float m_focalLength;

		// Token: 0x040020D5 RID: 8405
		[Token(Token = "0x40020D5")]
		[FieldOffset(Offset = "0x98")]
		[Header(0, "Exposure Settings")]
		[Slider("Exposure Compensation", useProperty = "exposureCompensation", visibleCheck = "ShowExposureComp", minValue = -8f, maxValue = 8f, tooltip = "Allows you to manually compensate towards the desired exposure")]
		public float m_exposureCompensation;

		// Token: 0x040020D6 RID: 8406
		[Token(Token = "0x40020D6")]
		[FieldOffset(Offset = "0x9C")]
		[MinMaxSlider("Min Max Exposure", -8f, 24f, useProperty = "minMaxExposure")]
		public Vector2 m_minMaxExposure;

		// Token: 0x040020D7 RID: 8407
		[Token(Token = "0x40020D7")]
		[FieldOffset(Offset = "0xA4")]
		[Slider("Adaption Speed", useProperty = "adaptionSpeed", visibleCheck = "ShowExposureAdaption", minValue = 0.1f, maxValue = 8f, tooltip = "How fast the exposure is allowed to change")]
		public float m_adaptionSpeed;

		// Token: 0x040020D8 RID: 8408
		[Token(Token = "0x40020D8")]
		[FieldOffset(Offset = "0xA8")]
		[Toggle("Active", useProperty = "depthOfField", tooltip = "Determines if depth of field is used")]
		[Header(0, "Depth of Field")]
		public bool m_depthOfField;

		// Token: 0x040020D9 RID: 8409
		[Token(Token = "0x40020D9")]
		[FieldOffset(Offset = "0xAC")]
		[Slider("Max Radius", useProperty = "maxCoCRadius", visibleCheck = "ShowDepthOfField", minValue = 10f, maxValue = 20f, tooltip = "The maximum radius the blur can be. Lower values might have less artifacts")]
		public float m_maxCoCRadius;

		// Token: 0x040020DA RID: 8410
		[Token(Token = "0x40020DA")]
		[FieldOffset(Offset = "0xB0")]
		[Field("Quality Level", useProperty = "depthOfFieldQuality", visibleCheck = "ShowDepthOfField", tooltip = "Dictates how many samples the algorithm does")]
		public DepthOfFieldQuality m_depthOfFieldQuality;

		// Token: 0x040020DB RID: 8411
		[Token(Token = "0x40020DB")]
		[FieldOffset(Offset = "0xB4")]
		[Field("Depth Focus Mode", useProperty = "depthFocusMode", visibleCheck = "ShowDepthOfField", tooltip = "How the depth focus point is chosen")]
		public DepthFocusMode m_depthFocusMode;

		// Token: 0x040020DC RID: 8412
		[Token(Token = "0x40020DC")]
		[FieldOffset(Offset = "0xB8")]
		[Field("Point Center", useProperty = "pointAveragePosition", visibleCheck = "ShowPointAverage", tooltip = "Where the center of focus is on the screen. [0,0] is the bottom left corner and [1,1] is the top right")]
		public Vector2 m_pointAveragePosition;

		// Token: 0x040020DD RID: 8413
		[Token(Token = "0x40020DD")]
		[FieldOffset(Offset = "0xC0")]
		[Space(0, 1)]
		[Slider("Point Range", useProperty = "pointAverageRange", visibleCheck = "ShowPointAverage", minValue = 0.01f, maxValue = 1f, tooltip = "How far the point average calculation reaches")]
		public float m_pointAverageRange;

		// Token: 0x040020DE RID: 8414
		[Token(Token = "0x40020DE")]
		[FieldOffset(Offset = "0xC4")]
		[Toggle("Visualize", useProperty = "visualizePointFocus", visibleCheck = "ShowPointAverage", tooltip = "Show the area of influence on the main screen for visualizaiton")]
		public bool m_visualizePointFocus;

		// Token: 0x040020DF RID: 8415
		[Token(Token = "0x40020DF")]
		[FieldOffset(Offset = "0xC8")]
		[Slider("Adaption Speed", useProperty = "depthAdaptionSpeed", visibleCheck = "ShowPointAverage", minValue = 1f, maxValue = 30f, tooltip = "Dictates how fast the focal distance changes")]
		public float m_depthAdaptionSpeed;

		// Token: 0x040020E0 RID: 8416
		[Token(Token = "0x40020E0")]
		[FieldOffset(Offset = "0xCC")]
		[Field("Focal Distance", useProperty = "focalDistance", visibleCheck = "ShowFocalDistance", tooltip = "The focal distance in meters")]
		public float m_focalDistance;

		// Token: 0x040020E1 RID: 8417
		[Token(Token = "0x40020E1")]
		[FieldOffset(Offset = "0xD0")]
		[Slider("Depth Range", useProperty = "focalRange", visibleCheck = "ShowFocalRange", minValue = 0f, maxValue = 50f, tooltip = "The length of the range that is 100% in focus")]
		public float m_focalRange;

		// Token: 0x040020E2 RID: 8418
		[Token(Token = "0x40020E2")]
		[FieldOffset(Offset = "0xD4")]
		[Header(0, "Color Correction")]
		[Field("Mode", useProperty = "colorGradingMode", tooltip = "Which color correction mode is currently active")]
		public ColorGradingMode m_colorGradingMode;

		// Token: 0x040020E3 RID: 8419
		[Token(Token = "0x40020E3")]
		[FieldOffset(Offset = "0xD8")]
		[Field("Compatibility", useProperty = "colorGradingCompatibility", visibleCheck = "ShowCCTex1", tooltip = "Sets the algorithm to be compatible with the lookup textures used by different shaders")]
		public ColorGradingCompatibility m_colorGradingCompatibility;

		// Token: 0x040020E4 RID: 8420
		[Token(Token = "0x40020E4")]
		[FieldOffset(Offset = "0xE0")]
		[Field("Lookup Texture", useProperty = "colorGradingTex1", visibleCheck = "ShowCCTex1", tooltip = "The lookup texture used for color correction")]
		public Texture2D m_colorGradingTex1;

		// Token: 0x040020E5 RID: 8421
		[Token(Token = "0x40020E5")]
		[FieldOffset(Offset = "0xE8")]
		[Field("Blend Lookup Texture", useProperty = "colorGradingTex2", visibleCheck = "ShowCCTex2", tooltip = "The lookup texture blended in as the blend factor increases")]
		public Texture2D m_colorGradingTex2;

		// Token: 0x040020E6 RID: 8422
		[Token(Token = "0x40020E6")]
		[FieldOffset(Offset = "0xF0")]
		[Slider("Blend Factor", useProperty = "colorGradingBlendFactor", visibleCheck = "ShowCCTex2", minValue = 0f, maxValue = 1f, tooltip = "Interpolates between the original color correction texture and the blend target color correction texture")]
		public float m_colorGradingBlendFactor;

		// Token: 0x040020E7 RID: 8423
		[Token(Token = "0x40020E7")]
		[FieldOffset(Offset = "0xF4")]
		private bool m_isFirstRender;

		// Token: 0x040020E8 RID: 8424
		[Token(Token = "0x40020E8")]
		[FieldOffset(Offset = "0xF8")]
		private float prevCamFoV;

		// Token: 0x040020E9 RID: 8425
		[Token(Token = "0x40020E9")]
		[FieldOffset(Offset = "0x100")]
		private Camera m_camera;

		// Token: 0x040020EA RID: 8426
		[Token(Token = "0x40020EA")]
		[FieldOffset(Offset = "0x108")]
		private Bloom m_bloomClass;

		// Token: 0x040020EB RID: 8427
		[Token(Token = "0x40020EB")]
		[FieldOffset(Offset = "0x110")]
		private VirtualCamera m_virtualCamera;

		// Token: 0x040020EC RID: 8428
		[Token(Token = "0x40020EC")]
		[FieldOffset(Offset = "0x118")]
		private CombinationPass m_combinationPass;

		// Token: 0x040020ED RID: 8429
		[Token(Token = "0x40020ED")]
		[FieldOffset(Offset = "0x120")]
		private Downsampling m_downsampling;

		// Token: 0x040020EE RID: 8430
		[Token(Token = "0x40020EE")]
		[FieldOffset(Offset = "0x128")]
		private DepthOfField m_depthOfFieldClass;

		// Token: 0x040020EF RID: 8431
		[Token(Token = "0x40020EF")]
		[FieldOffset(Offset = "0x130")]
		private ColorGrading m_colorGrading;

		// Token: 0x040020F0 RID: 8432
		[Token(Token = "0x40020F0")]
		[FieldOffset(Offset = "0x138")]
		private PostProcessParameters postProcessParams;

		// Token: 0x040020F1 RID: 8433
		[Token(Token = "0x40020F1")]
		[FieldOffset(Offset = "0x140")]
		private ScionDebug m_scionDebug;

		// Token: 0x040020F2 RID: 8434
		[Token(Token = "0x40020F2")]
		[FieldOffset(Offset = "0x0")]
		public static ScionDebug ActiveDebug;
	}
}
