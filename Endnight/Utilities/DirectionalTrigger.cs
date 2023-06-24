using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Endnight.Utilities
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	[AddComponentMenu("Sons/Word/Directional Trigger")]
	public class DirectionalTrigger : MonoBehaviour
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		private event Action<GameObject> _onExitedAEvent
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0xA6E830", Offset = "0xA6CE30", VA = "0x180A6E830")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0xA6E9A0", Offset = "0xA6CFA0", VA = "0x180A6E9A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		private event Action<GameObject> _onExitedBEvent
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0xA6EB10", Offset = "0xA6D110", VA = "0x180A6EB10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0xA6EC80", Offset = "0xA6D280", VA = "0x180A6EC80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xA6EDF0", Offset = "0xA6D3F0", VA = "0x180A6EDF0")]
		private void OnEnable()
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xA6F080", Offset = "0xA6D680", VA = "0x180A6F080")]
		private void OnDisable()
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xA6F320", Offset = "0xA6D920", VA = "0x180A6F320")]
		private void LateUpdate()
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xA6F5E0", Offset = "0xA6DBE0", VA = "0x180A6F5E0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xA70AB0", Offset = "0xA6F0B0", VA = "0x180A70AB0")]
		private void ResetTracking()
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xA70BE0", Offset = "0xA6F1E0", VA = "0x180A70BE0")]
		private void OnAExit(GameObject source)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xA70D40", Offset = "0xA6F340", VA = "0x180A70D40")]
		private void OnBExit(GameObject source)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xA70EA0", Offset = "0xA6F4A0", VA = "0x180A70EA0")]
		private void OnColliderExit(GameObject source, List<GameObject> trackedAdjacentList, TriggerDirection verifyDirection, Action<GameObject> verifiedAction)
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xA710B0", Offset = "0xA6F6B0", VA = "0x180A710B0")]
		private bool VerifyDirection(GameObject source, TriggerDirection directionToCheck)
		{
			return default(bool);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xA71180", Offset = "0xA6F780", VA = "0x180A71180")]
		private void TriggerExitedA(GameObject source)
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xA711A0", Offset = "0xA6F7A0", VA = "0x180A711A0")]
		private void TriggerExitedB(GameObject source)
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xA711C0", Offset = "0xA6F7C0", VA = "0x180A711C0")]
		private void OnAEnter(GameObject source)
		{
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xA712C0", Offset = "0xA6F8C0", VA = "0x180A712C0")]
		private void CheckAddToTracked(GameObject source, TriggerDirection direction)
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xA713E0", Offset = "0xA6F9E0", VA = "0x180A713E0")]
		private void ClearTracking(GameObject source)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xA714F0", Offset = "0xA6FAF0", VA = "0x180A714F0")]
		private void ClearTracking(int index)
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xA715B0", Offset = "0xA6FBB0", VA = "0x180A715B0")]
		private void OnBEnter(GameObject source)
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xA716B0", Offset = "0xA6FCB0", VA = "0x180A716B0")]
		public void SetLabels(string triggerALabel, string triggerBlabel)
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xA6E830", Offset = "0xA6CE30", VA = "0x180A6E830")]
		public void RegisterATrigger(Action<GameObject> action)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xA6EB10", Offset = "0xA6D110", VA = "0x180A6EB10")]
		public void RegisterBTrigger(Action<GameObject> action)
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xA6E9A0", Offset = "0xA6CFA0", VA = "0x180A6E9A0")]
		public void UnregisterATrigger(Action<GameObject> action)
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xA6EC80", Offset = "0xA6D280", VA = "0x180A6EC80")]
		public void UnregisterBTrigger(Action<GameObject> action)
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xA71760", Offset = "0xA6FD60", VA = "0x180A71760")]
		public void TriggerA()
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xA717A0", Offset = "0xA6FDA0", VA = "0x180A717A0")]
		public void TriggerB()
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xA717E0", Offset = "0xA6FDE0", VA = "0x180A717E0")]
		public DirectionalTrigger()
		{
		}

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _useInnerBoundary;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("_outerCollider")]
		private FilterTriggerCollider _colliderA;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("_innerCollider")]
		private FilterTriggerCollider _colliderB;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<GameObject> _trackedObjects;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<TriggerDirection> _trackedDirections;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[FormerlySerializedAs("_trackedOuter")]
		private List<GameObject> _trackedA;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[FormerlySerializedAs("_trackedInner")]
		private List<GameObject> _trackedB;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x58")]
		private List<GameObject> _toRemoveB;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x60")]
		private List<GameObject> _toRemoveA;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _aLabel;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string _bLabel;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x78")]
		private HashSet<GameObject> _inTransitions;
	}
}
