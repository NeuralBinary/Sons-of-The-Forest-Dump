using System;
using Il2CppDummyDll;
using Sons.Atmosphere;
using TheForest.World;
using UnityEngine;

namespace Sons.World
{
	// Token: 0x020004DF RID: 1247
	[Token(Token = "0x20004DF")]
	public class ObjectRainInteraction : MonoBehaviour, IRainReceiver
	{
		// Token: 0x060020B5 RID: 8373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B5")]
		[Address(RVA = "0x331CD00", Offset = "0x331B300", VA = "0x18331CD00")]
		private void OnValidate()
		{
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B6")]
		[Address(RVA = "0x331CED0", Offset = "0x331B4D0", VA = "0x18331CED0")]
		private void Awake()
		{
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B7")]
		[Address(RVA = "0x331D000", Offset = "0x331B600", VA = "0x18331D000")]
		private void Update()
		{
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B8")]
		[Address(RVA = "0x331D010", Offset = "0x331B610", VA = "0x18331D010")]
		private void Initialize()
		{
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B9")]
		[Address(RVA = "0x331D200", Offset = "0x331B800", VA = "0x18331D200")]
		private void OnEnable()
		{
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020BA")]
		[Address(RVA = "0x331D210", Offset = "0x331B810", VA = "0x18331D210")]
		private void OnDisable()
		{
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020BB")]
		[Address(RVA = "0x331D360", Offset = "0x331B960", VA = "0x18331D360")]
		private void OnDestroy()
		{
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020BC")]
		[Address(RVA = "0x331D3B0", Offset = "0x331B9B0", VA = "0x18331D3B0", Slot = "4")]
		public void UpdateRain(bool isRaining)
		{
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020BD")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ObjectRainInteraction()
		{
		}

		// Token: 0x04001E72 RID: 7794
		[Token(Token = "0x4001E72")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		private FMOD_StudioEventEmitter _rainHitAudioEmitter;

		// Token: 0x04001E73 RID: 7795
		[Token(Token = "0x4001E73")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Component _audioEmitter;

		// Token: 0x04001E74 RID: 7796
		[Token(Token = "0x4001E74")]
		[FieldOffset(Offset = "0x30")]
		private WeatherSystem _weatherSystem;

		// Token: 0x04001E75 RID: 7797
		[Token(Token = "0x4001E75")]
		[FieldOffset(Offset = "0x38")]
		private bool _initialized;

		// Token: 0x04001E76 RID: 7798
		[Token(Token = "0x4001E76")]
		[FieldOffset(Offset = "0x40")]
		private IFMODEmitter _rainAudioEmitter;
	}
}
