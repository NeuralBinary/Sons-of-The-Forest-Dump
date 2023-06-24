using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Bolt
{
	// Token: 0x02000097 RID: 151
	[Token(Token = "0x2000097")]
	[Documentation]
	public interface IState : IDisposable
	{
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000508 RID: 1288
		[Token(Token = "0x170000F5")]
		Animator Animator { [Token(Token = "0x6000508")] get; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000509 RID: 1289
		[Token(Token = "0x170000F6")]
		IEnumerable<Animator> AllAnimators { [Token(Token = "0x6000509")] get; }

		// Token: 0x0600050A RID: 1290
		[Token(Token = "0x600050A")]
		void SetAnimator(Animator animator);

		// Token: 0x0600050B RID: 1291
		[Token(Token = "0x600050B")]
		void AddAnimator(Animator animator);

		// Token: 0x0600050C RID: 1292
		[Token(Token = "0x600050C")]
		void AddCallback(string path, PropertyCallback callback);

		// Token: 0x0600050D RID: 1293
		[Token(Token = "0x600050D")]
		void AddCallback(string path, PropertyCallbackSimple callback);

		// Token: 0x0600050E RID: 1294
		[Token(Token = "0x600050E")]
		void RemoveCallback(string path, PropertyCallback callback);

		// Token: 0x0600050F RID: 1295
		[Token(Token = "0x600050F")]
		void RemoveCallback(string path, PropertyCallbackSimple callback);

		// Token: 0x06000510 RID: 1296
		[Token(Token = "0x6000510")]
		void SetDynamic(string property, object value);

		// Token: 0x06000511 RID: 1297
		[Token(Token = "0x6000511")]
		object GetDynamic(string property);
	}
}
