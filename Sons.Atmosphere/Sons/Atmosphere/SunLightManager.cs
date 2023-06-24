using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Sons.Atmosphere
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	public class SunLightManager : MonoBehaviour
	{
		// Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x2D4C180", Offset = "0x2D4A780", VA = "0x182D4C180")]
		private void Awake()
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x2D4C3D0", Offset = "0x2D4A9D0", VA = "0x182D4C3D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x2D4C560", Offset = "0x2D4AB60", VA = "0x182D4C560")]
		public static void Register(ISunLightReceiver receiver)
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x2D4C660", Offset = "0x2D4AC60", VA = "0x182D4C660")]
		private void RegisterInternal(ISunLightReceiver receiver)
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x2D4C800", Offset = "0x2D4AE00", VA = "0x182D4C800")]
		public static void SetLight(GameObject sunlightGameObject, Light sunlight, HDAdditionalLightData lightData)
		{
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x2D4C930", Offset = "0x2D4AF30", VA = "0x182D4C930")]
		private void SetLightInternal(GameObject sunlightGameObject, Light sunlight, HDAdditionalLightData lightData)
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x2D4CB70", Offset = "0x2D4B170", VA = "0x182D4CB70")]
		private void UpdateReceivers()
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x2D4CD60", Offset = "0x2D4B360", VA = "0x182D4CD60")]
		private void UpdateReceiver(ISunLightReceiver eachReceiver)
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2D4CE40", Offset = "0x2D4B440", VA = "0x182D4CE40")]
		public static void Unregister(ISunLightReceiver receiver)
		{
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x2D4D000", Offset = "0x2D4B600", VA = "0x182D4D000")]
		private void UnregisterInternal(ISunLightReceiver receiver)
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x2D4D0E0", Offset = "0x2D4B6E0", VA = "0x182D4D0E0")]
		public static Light GetLight()
		{
			return null;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SunLightManager()
		{
		}

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x0")]
		private static SunLightManager _instance;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x20")]
		private List<ISunLightReceiver> _receivers;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x28")]
		private GameObject _sunlightGameObject;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x30")]
		private Light _sunLight;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x38")]
		private HDAdditionalLightData _lightData;
	}
}
