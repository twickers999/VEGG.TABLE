$commitMsg = Get-Content -Path $args[0] -Raw
# Regex: type(optional scope): description, optional (Closes|Relates to) #issue
$pattern = '^(feat|fix|docs|refactor|test|chore)(\(.+\))?: .{1,50}(\s(Closes|Relates to) #\d+)?$'

if ($commitMsg -notmatch $pattern) {
    Write-Error "Invalid commit message format."
    Write-Host "Expected format: 'feat(scope): description' or 'feat: description', with optional 'Closes #1'"
    exit 1
}