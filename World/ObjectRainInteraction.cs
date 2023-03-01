using System;
using Il2CppDummyDll;
using Sons.Atmosphere;
using TheForest.World;
using UnityEngine;

namespace Sons.World
{
	// Token: 0x020004E9 RID: 1257
	[Token(Token = "0x20004E9")]
	public class ObjectRainInteraction : MonoBehaviour, IRainReceiver
	{
		// Token: 0x06002042 RID: 8258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002042")]
		[Address(RVA = "0x2D2C370", Offset = "0x2D2B370", VA = "0x182D2C370")]
		private void OnValidate()
		{
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002043")]
		[Address(RVA = "0x2D2C0D0", Offset = "0x2D2B0D0", VA = "0x182D2C0D0")]
		private void Awake()
		{
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002044")]
		[Address(RVA = "0x2D2C470", Offset = "0x2D2B470", VA = "0x182D2C470")]
		private void Update()
		{
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002045")]
		[Address(RVA = "0x2D2C190", Offset = "0x2D2B190", VA = "0x182D2C190")]
		private void Initialize()
		{
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002046")]
		[Address(RVA = "0x2D2C360", Offset = "0x2D2B360", VA = "0x182D2C360")]
		private void OnEnable()
		{
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002047")]
		[Address(RVA = "0x2D2C2B0", Offset = "0x2D2B2B0", VA = "0x182D2C2B0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002048")]
		[Address(RVA = "0x2D2C260", Offset = "0x2D2B260", VA = "0x182D2C260")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002049")]
		[Address(RVA = "0x2D2C410", Offset = "0x2D2B410", VA = "0x182D2C410", Slot = "4")]
		public void UpdateRain(bool isRaining)
		{
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204A")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ObjectRainInteraction()
		{
		}

		// Token: 0x04001E17 RID: 7703
		[Token(Token = "0x4001E17")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private FMOD_StudioEventEmitter _rainHitAudioEmitter;

		// Token: 0x04001E18 RID: 7704
		[Token(Token = "0x4001E18")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Component _audioEmitter;

		// Token: 0x04001E19 RID: 7705
		[Token(Token = "0x4001E19")]
		[FieldOffset(Offset = "0x30")]
		private WeatherSystem _weatherSystem;

		// Token: 0x04001E1A RID: 7706
		[Token(Token = "0x4001E1A")]
		[FieldOffset(Offset = "0x38")]
		private bool _initialized;

		// Token: 0x04001E1B RID: 7707
		[Token(Token = "0x4001E1B")]
		[FieldOffset(Offset = "0x40")]
		private IFMODEmitter _rainAudioEmitter;
	}
}
