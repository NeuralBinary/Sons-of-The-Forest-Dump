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
	// Token: 0x0200074A RID: 1866
	[Token(Token = "0x200074A")]
	[AddComponentMenu("Sons/Gameplay/BoatEngine")]
	public class BoatEngine : MonoBehaviour
	{
		// Token: 0x06003239 RID: 12857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003239")]
		[Address(RVA = "0x349A760", Offset = "0x3498D60", VA = "0x18349A760")]
		private void Start()
		{
		}

		// Token: 0x0600323A RID: 12858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600323A")]
		[Address(RVA = "0x349A880", Offset = "0x3498E80", VA = "0x18349A880")]
		private void OnEnable()
		{
		}

		// Token: 0x0600323B RID: 12859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600323B")]
		[Address(RVA = "0x349A890", Offset = "0x3498E90", VA = "0x18349A890")]
		private void OnDisable()
		{
		}

		// Token: 0x0600323C RID: 12860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600323C")]
		[Address(RVA = "0x349A8C0", Offset = "0x3498EC0", VA = "0x18349A8C0")]
		private void Update()
		{
		}

		// Token: 0x0600323D RID: 12861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600323D")]
		[Address(RVA = "0x349AA70", Offset = "0x3499070", VA = "0x18349AA70")]
		public void StopIdleEvent(bool immediate)
		{
		}

		// Token: 0x0600323E RID: 12862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600323E")]
		[Address(RVA = "0x349AAA0", Offset = "0x34990A0", VA = "0x18349AAA0")]
		private void PlayIdleEvent()
		{
		}

		// Token: 0x0600323F RID: 12863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600323F")]
		[Address(RVA = "0x349ACD0", Offset = "0x34992D0", VA = "0x18349ACD0")]
		private void OnImpact(IImpactSender sender, IImpactData impactData)
		{
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003240")]
		[Address(RVA = "0x349AEF0", Offset = "0x34994F0", VA = "0x18349AEF0")]
		private void ReceiveDamageServer(float damage)
		{
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003241")]
		[Address(RVA = "0x349B0B0", Offset = "0x34996B0", VA = "0x18349B0B0")]
		private void SendHitEngineToServer(float damage)
		{
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003242")]
		[Address(RVA = "0x349B1D0", Offset = "0x34997D0", VA = "0x18349B1D0")]
		private void SendExplodeEngineToClients()
		{
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003243")]
		[Address(RVA = "0x349B260", Offset = "0x3499860", VA = "0x18349B260")]
		public void ReceivedHitEngineEvent(HitEngineEvent evnt)
		{
		}

		// Token: 0x06003244 RID: 12868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003244")]
		[Address(RVA = "0x349B380", Offset = "0x3499980", VA = "0x18349B380")]
		public void OnExplode()
		{
		}

		// Token: 0x06003245 RID: 12869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003245")]
		[Address(RVA = "0x349B7A0", Offset = "0x3499DA0", VA = "0x18349B7A0")]
		public BoatEngine()
		{
		}

		// Token: 0x04002B52 RID: 11090
		[Token(Token = "0x4002B52")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _explosionObject;

		// Token: 0x04002B53 RID: 11091
		[Token(Token = "0x4002B53")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> _hideObjects;

		// Token: 0x04002B54 RID: 11092
		[Token(Token = "0x4002B54")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _health;

		// Token: 0x04002B55 RID: 11093
		[Token(Token = "0x4002B55")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private VailActor _actor;

		// Token: 0x04002B56 RID: 11094
		[Token(Token = "0x4002B56")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DamageNode _damageNode;

		// Token: 0x04002B57 RID: 11095
		[Token(Token = "0x4002B57")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[EventRef]
		private string _onImpactEvent;

		// Token: 0x04002B58 RID: 11096
		[Token(Token = "0x4002B58")]
		[FieldOffset(Offset = "0x50")]
		[EventRef]
		[SerializeField]
		private string _onDestroyedEvent;

		// Token: 0x04002B59 RID: 11097
		[Token(Token = "0x4002B59")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[EventRef]
		private string _idleEngineEvent;

		// Token: 0x04002B5A RID: 11098
		[Token(Token = "0x4002B5A")]
		[FieldOffset(Offset = "0x60")]
		private EventInstance _playingEvent;
	}
}
