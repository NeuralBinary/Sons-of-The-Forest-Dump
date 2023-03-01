using System;
using System.Collections.Generic;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Weapon;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200062E RID: 1582
	[Token(Token = "0x200062E")]
	[AddComponentMenu("Sons/Gameplay/BoatEngine")]
	public class BoatEngine : MonoBehaviour
	{
		// Token: 0x06002864 RID: 10340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002864")]
		[Address(RVA = "0x2DACB80", Offset = "0x2DABB80", VA = "0x182DACB80")]
		private void Start()
		{
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002865")]
		[Address(RVA = "0x2DAC370", Offset = "0x2DAB370", VA = "0x182DAC370")]
		private void OnEnable()
		{
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002866")]
		[Address(RVA = "0x2DAC340", Offset = "0x2DAB340", VA = "0x182DAC340")]
		private void OnDisable()
		{
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002867")]
		[Address(RVA = "0x2DACC80", Offset = "0x2DABC80", VA = "0x182DACC80")]
		private void Update()
		{
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002868")]
		[Address(RVA = "0x2DACC50", Offset = "0x2DABC50", VA = "0x182DACC50")]
		public void StopIdleEvent(bool immediate)
		{
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002869")]
		[Address(RVA = "0x2DAC370", Offset = "0x2DAB370", VA = "0x182DAC370")]
		private void PlayIdleEvent()
		{
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600286A")]
		[Address(RVA = "0x2DAC710", Offset = "0x2DAB710", VA = "0x182DAC710")]
		private void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600286B")]
		[Address(RVA = "0x2DAC880", Offset = "0x2DAB880", VA = "0x182DAC880")]
		private void ReceiveDamageServer(float damage)
		{
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600286C")]
		[Address(RVA = "0x2DACAE0", Offset = "0x2DABAE0", VA = "0x182DACAE0")]
		private void SendHitEngineToServer(float damage)
		{
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600286D")]
		[Address(RVA = "0x2DACA60", Offset = "0x2DABA60", VA = "0x182DACA60")]
		private void SendExplodeEngineToClients()
		{
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600286E")]
		[Address(RVA = "0x2DAC9C0", Offset = "0x2DAB9C0", VA = "0x182DAC9C0")]
		public void ReceivedHitEngineEvent(HitEngineEvent evnt)
		{
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600286F")]
		[Address(RVA = "0x2DAC4D0", Offset = "0x2DAB4D0", VA = "0x182DAC4D0")]
		public void OnExplode()
		{
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002870")]
		[Address(RVA = "0x2DACD30", Offset = "0x2DABD30", VA = "0x182DACD30")]
		public BoatEngine()
		{
		}

		// Token: 0x04002414 RID: 9236
		[Token(Token = "0x4002414")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _explosionObject;

		// Token: 0x04002415 RID: 9237
		[Token(Token = "0x4002415")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> _hideObjects;

		// Token: 0x04002416 RID: 9238
		[Token(Token = "0x4002416")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _health;

		// Token: 0x04002417 RID: 9239
		[Token(Token = "0x4002417")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private VailActor _actor;

		// Token: 0x04002418 RID: 9240
		[Token(Token = "0x4002418")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DamageNode _damageNode;

		// Token: 0x04002419 RID: 9241
		[Token(Token = "0x4002419")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[EventRef]
		private string _onImpactEvent;

		// Token: 0x0400241A RID: 9242
		[Token(Token = "0x400241A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[EventRef]
		private string _onDestroyedEvent;

		// Token: 0x0400241B RID: 9243
		[Token(Token = "0x400241B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[EventRef]
		private string _idleEngineEvent;

		// Token: 0x0400241C RID: 9244
		[Token(Token = "0x400241C")]
		[FieldOffset(Offset = "0x60")]
		private EventInstance _playingEvent;
	}
}
