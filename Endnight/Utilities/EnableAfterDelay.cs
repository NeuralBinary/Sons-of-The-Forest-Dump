using System;
using System.Collections.Generic;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Endnight.Utilities
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	[AddComponentMenu("Sons/Utils/EnableAfterDelay")]
	public class EnableAfterDelay : MonoBehaviour
	{
		// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xA71D10", Offset = "0xA70310", VA = "0x180A71D10")]
		private void OnValidate()
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xA71D20", Offset = "0xA70320", VA = "0x180A71D20")]
		private void ConvertToList()
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xA71F30", Offset = "0xA70530", VA = "0x180A71F30")]
		private void Update()
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xA71F80", Offset = "0xA70580", VA = "0x180A71F80")]
		private void Start()
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xA72090", Offset = "0xA70690", VA = "0x180A72090")]
		private void DoActivation()
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public EnableAfterDelay()
		{
		}

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		[FormerlySerializedAs("go")]
		[Obsolete]
		private GameObject _targetGameObject;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> _targets;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("delay")]
		private float _delay;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x38")]
		private AutoTimer _delayTimer;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x40")]
		private bool _completed;
	}
}
