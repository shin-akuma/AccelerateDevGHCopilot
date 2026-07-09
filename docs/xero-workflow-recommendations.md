# Agentic Workflow Recommendations for Xero

## Xero profile (relevant to workflow selection)

| Attribute | Implication for workflow choice |
|-----------|--------------------------------|
| Cloud accounting SaaS handling financial + tax data | Security and compliance workflows are high priority |
| ~4,600 staff, distributed across NZ, AU, UK, US, Canada, SA, Singapore + India base | Team-coordination and status workflows add value at scale |
| Heavy regulatory compliance (Making Tax Digital, Single Touch Payroll, Payday Filing) | Contribution/compliance-gate workflows matter |
| 20-year-old codebase, multiple acquisitions (Melio, Hubdoc, TaxCycle, Syft) | Tech-debt, test coverage, and code-quality workflows are valuable |
| Large-scale CI (public company, frequent releases) | CI cost/speed optimization has real financial impact |
| 2026 Anthropic AI partnership — culturally AI-forward | Organization is receptive to agentic tooling |

## Recommended workflows (ranked by fit)

### Tier 1 — Highest value for Xero

| Workflow | Why it fits Xero specifically |
|----------|-------------------------------|
| 🔍 Daily Malicious Code Scan | Fintech handling financial data — supply-chain/malicious-code detection is critical. Non-negotiable for a regulated payments company. |
| 🔒 VEX Generator | Auto-generates OpenVEX statements for Dependabot alerts — directly supports the audit/compliance posture a public fintech needs. |
| 🏥 CI Doctor + 🚀 CI Coach + 💰 Cost Tracker | At Xero's scale, CI spend and flaky-test triage are large recurring costs. Cost Tracker gives per-run agent-spend visibility (exactly the token-cost concern you've been working on). |
| 🧪 Daily Test Improver | A 20-year codebase with acquired products almost certainly has under-tested areas. Safe, PR-based coverage improvement. |

### Tier 2 — Strong fit at team scale

| Workflow | Why |
|----------|-----|
| ✅ Contribution Guidelines Checker / 🔍 Contribution Check | Enforces consistency across a large, geographically distributed contributor base and acquired teams. |
| 😤 Grumpy Reviewer / 🔍 PR Nitpick Reviewer | On-demand senior-level review — useful for onboarding acquired-company engineers to Xero standards. |
| 👥 Daily Team Status / 📋 Daily Plan | Coordination across NZ/AU/UK/US/India time zones; upbeat rollups and planning issues reduce sync overhead. |
| 🔍 Duplicate Code Detector / ✨ Code Simplifier | Post-acquisition integration inevitably creates duplication; targeted refactoring PRs help consolidate. |

### Tier 3 — Situational / start-small

| Workflow | Why |
|----------|-----|
| 🤖 Repo Assist | The all-in-one you're already tuning. Powerful but token-heavy — best deployed on a few flagship repos first, not org-wide, given the cost profile you've measured. |
| 📖 Daily Documentation Updater / 📝 Wiki Writer | Keeps docs aligned with rapid change across many product lines. |
| ⚡ Daily Perf Improver | Valuable but lower priority than security/CI for an accounting SaaS. |

### Non-code (for Xero's PM/compliance functions)

From the companion **agentics-beyond-code** collection: **Compliance Review** (Security/Privacy/Accessibility/Responsible-AI rubrics) and **Launch Readiness Checker** map directly onto a regulated fintech's release governance.

## Suggested rollout for Xero

1. **Start with security + CI cost workflows (Tier 1)** on 2–3 high-traffic repos — clearest ROI, lowest risk, directly measurable savings.
2. **Add code review + contribution gates (Tier 2)** to standardize the distributed/acquired teams.
3. **Pilot Repo Assist** on a single active repo with the token-saving tuning you've already built (reduced weights, memory caps, output limits) before wider adoption.
4. **Watch spend with Cost Tracker** from day one, since agentic workflows at Xero's scale can accumulate cost quickly.

> **Note:** Xero's exact current tech stack could not be confirmed (their public "about" page blocked automated fetch), so the code-specific recommendations assume a large polyglot cloud codebase — adjust the language-specific tooling (Test Improver, Perf Improver) to their actual primary languages.
