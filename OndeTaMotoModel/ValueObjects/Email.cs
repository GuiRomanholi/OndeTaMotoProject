namespace OndeTaMotoModel.ValueObjects;

public sealed class Email
{
    public string Endereco { get; }

    public Email(string endereco)
    {
        if (string.IsNullOrWhiteSpace(endereco))
        {
            throw new ArgumentException("O endereço de e-mail não pode ser vazio.", nameof(endereco));
        }
        
        try
        {
            var addr = new System.Net.Mail.MailAddress(endereco);
            if (addr.Address != endereco)
            {
                throw new ArgumentException("Formato de e-mail inválido.", nameof(endereco));
            }
        }
        catch
        {
            throw new ArgumentException("Formato de e-mail inválido.", nameof(endereco));
        }

        Endereco = endereco;
    }

    public override bool Equals(object obj)
    {
        return obj is Email other && string.Equals(Endereco, other.Endereco, StringComparison.OrdinalIgnoreCase);
    }

    public override int GetHashCode()
    {
        return Endereco.GetHashCode(StringComparison.OrdinalIgnoreCase);
    }
}